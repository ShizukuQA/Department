using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages.Admin {
    partial class ManageTeachers {
        private ListBox lstTeachers;
        private Button btnAddTeacher;
        private Button btnRemoveTeacher;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lstTeachers = new ListBox();
            btnAddTeacher = new Button();
            btnRemoveTeacher = new Button();
            SuspendLayout();
            // 
            // lstTeachers
            // 
            lstTeachers.ItemHeight = 15;
            lstTeachers.Location = new Point(14, 14);
            lstTeachers.Margin = new Padding(4, 3, 4, 3);
            lstTeachers.Name = "lstTeachers";
            lstTeachers.Size = new Size(303, 169);
            lstTeachers.TabIndex = 0;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(14, 198);
            btnAddTeacher.Margin = new Padding(4, 3, 4, 3);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(88, 27);
            btnAddTeacher.TabIndex = 1;
            btnAddTeacher.Text = "Добавить преподавателя";
            btnAddTeacher.Click += BtnAddTeacher_Click;
            // 
            // btnRemoveTeacher
            // 
            btnRemoveTeacher.Location = new Point(230, 198);
            btnRemoveTeacher.Margin = new Padding(4, 3, 4, 3);
            btnRemoveTeacher.Name = "btnRemoveTeacher";
            btnRemoveTeacher.Size = new Size(88, 27);
            btnRemoveTeacher.TabIndex = 2;
            btnRemoveTeacher.Text = "Удалить преподавателя";
            btnRemoveTeacher.Click += BtnRemoveTeacher_Click;
            // 
            // ManageTeachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 243);
            Controls.Add(lstTeachers);
            Controls.Add(btnAddTeacher);
            Controls.Add(btnRemoveTeacher);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageTeachers";
            Text = "Управление пользователями";
            ResumeLayout(false);
        }

        #endregion
    }
}