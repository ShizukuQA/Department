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
    public partial class AddTeacher : Form {
        private DatabaseContext db;

        public AddTeacher(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            try {
                User teacher = new User() {
                    Firstname = txtName.Text,
                    SecondName = txtSurname.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    IsAdmin = false
                };
                db.Users.Add(teacher);
                db.SaveChanges();
                MessageBox.Show("Преподаватель добавлен!");
            }
            catch {
                MessageBox.Show("Неизвестная ошибка");
            }
        }
    }
}
