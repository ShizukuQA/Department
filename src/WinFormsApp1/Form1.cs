using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Database.Models;
using WindowsFormsApp1.Pages;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        private DatabaseContext db = new DatabaseContext("DataSource=Database.db");

        public Form1() {
            InitializeComponent();
        }

        private void entry_Click(object sender, EventArgs e) {
            User user = db.Users.FirstOrDefault(x => x.Email == txtUsername.Text && x.Password == txtPassword.Text);
            if (user == null) {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }

            if (user.IsAdmin) new AdminForm(db).Show();
            else new UserForm().Show();
        }
    }
}
