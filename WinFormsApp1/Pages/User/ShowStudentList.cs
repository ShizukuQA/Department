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
    public partial class ShowStudentList : Form {
        private DatabaseContext db;

        public ShowStudentList(DatabaseContext db) {
            InitializeComponent();
            this.db = db;
            dataGridView1.DataSource = db.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = db.Students.ToList();
        }
    }
}
