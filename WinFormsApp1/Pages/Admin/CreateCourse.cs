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

namespace WindowsFormsApp1.Pages.Admin {
    public partial class CreateCourse : Form {
        private DatabaseContext db;

        public CreateCourse(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtCourseName.Text)) {
                MessageBox.Show("Название не может быть пустым");
                return;
            }

            try {
                Course course = new Course() {
                    Name = txtCourseName.Text
                };
                db.Courses.Add(course);
                db.SaveChanges();
                MessageBox.Show("Курс создан!");
            }
            catch {
                MessageBox.Show("Неизвестная ошибка");
            }
        }
    }
}
