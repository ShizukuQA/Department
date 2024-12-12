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
using WindowsFormsApp1.Pages.Admin;

namespace WindowsFormsApp1.Pages {
    public partial class AdminForm : Form {
        private DatabaseContext db;

        public AdminForm(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
        }

        private void BtnCreateCourse_Click(object sender, EventArgs e) {
            new CreateCourse(db).Show();
        } 

        private void BtnAddStudent_Click(object sender, EventArgs e) {
            new AddStudent(db).Show();
        } 

        private void BtnEditSchedule_Click(object sender, EventArgs e) { 
            new EditSchedule(db).Show();
        }

        private void BtnManageTeachers_Click(object sender, EventArgs e) { 
            new ManageTeachers(db).Show();
        }
    }
}
