using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Database.Models;
using WinFormsApp1.Pages.User;

namespace WindowsFormsApp1.Pages {
    public partial class UserForm : Form {
        private DatabaseContext db;

        public UserForm(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e) {
            new ShowStudentList(db).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            new ShowTeacherList(db).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            new ShowCourseList(db).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            ExportToCsv();
        }

        private void ExportToCsv() { 
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv"; 
                saveFileDialog.Title = "Сохранить как CSV файл";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) { 
                    string filePath = saveFileDialog.FileName; 
                    SaveDataToCsv(filePath); 
                } 
            } 
        }

        private void SaveDataToCsv(string filePath) {
            try {
                var data = db.Courses.ToList(); 
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8)) {
                    var properties = typeof(Course).GetProperties();
                    writer.WriteLine(string.Join(",", properties.Select(p => p.Name)));
                    foreach (var item in data) { 
                        writer.WriteLine(string.Join(",", properties.Select(p => p.GetValue(item))));
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Ошибка: " + ex.Message); 
            } 
        } 
    }
}
