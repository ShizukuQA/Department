using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Database;
using WindowsFormsApp2.Database.Models;

namespace WindowsFormsApp2.Pages.Admin {
    public partial class AddStudent : Form {
        private DatabaseContext db;

        public AddStudent(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            try {
                Student student = new Student() {
                    Firstname = txtStudentName.Text,
                    SecondName = txtStudentSurname.Text,
                    Email = txtStudentEmail.Text
                };
                db.Students.Add(student);
                db.SaveChanges();
                MessageBox.Show("Студент добавлен!");
            }
            catch {
                MessageBox.Show("Неизвестная ошибка");
            }
        }
    }
}
