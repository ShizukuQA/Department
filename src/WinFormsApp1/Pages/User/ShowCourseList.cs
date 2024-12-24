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

namespace WinFormsApp1.Pages.User {
    public partial class ShowCourseList : Form {
        private DatabaseContext db;

        public ShowCourseList(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
            dataGridView1.DataSource = db.Courses.ToList();
        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = db.Courses.ToList();
        }
    }
}
