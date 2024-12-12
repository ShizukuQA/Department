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

namespace WindowsFormsApp1.Pages.Admin {
    public partial class ManageTeachers : Form {
        private DatabaseContext db;

        public ManageTeachers(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
            LoadTeachers();
        }

        private void LoadTeachers() { 
            lstTeachers.Items.Clear();
            foreach (var teacher in db.Users) { 
                lstTeachers.Items.Add($"{teacher.Id}: {teacher.Firstname} {teacher.SecondName}"); 
            } 
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e) {
            new AddTeacher(db).Show();
            LoadTeachers();
        }
        
        private void BtnRemoveTeacher_Click(object sender, EventArgs e) { 
            try {
                if (lstTeachers.SelectedItem != null) { 
                    var selectedTeacher = lstTeachers.SelectedItem.ToString();
                    var teacherId = int.Parse(selectedTeacher.Split(':')[0]); 
                    var teacher = db.Users.First(x => x.Id == teacherId && !x.IsAdmin);
                    db.Users.Remove(teacher);
                    db.SaveChanges();
                    LoadTeachers(); 
                }
                else MessageBox.Show("Выберите преподавателя");
            }
            catch {
                MessageBox.Show("Неизвестная ошибка");
            }
        }
    }
}
