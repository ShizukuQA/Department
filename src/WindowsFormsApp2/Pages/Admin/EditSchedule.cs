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
    public partial class EditSchedule : Form {
        private DatabaseContext db;

        public EditSchedule(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            try {
                Schedule schedule = new Schedule() {
                    Classroom = txtRoom.Text,
                    DateTime = dtpDate.Value,
                    Course = db.Courses.First(x => x.Id == (int)cmbCourses.SelectedValue)
                };
                db.Schedules.Add(schedule);
                db.SaveChanges();
                MessageBox.Show("Расписание изменено!");
            }
            catch {
                MessageBox.Show("Неизвестная ошибка");
            }
        }
    }
}
