using System;
using System.Windows.Forms;

namespace WindowsFormsApp2.Pages.Admin {
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
            this.lstTeachers = new System.Windows.Forms.ListBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTeachers
            // 
            this.lstTeachers.Location = new System.Drawing.Point(12, 12);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(260, 147);
            this.lstTeachers.TabIndex = 0;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(12, 172);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Добавить преподавателя";
            this.btnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Location = new System.Drawing.Point(197, 172);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTeacher.TabIndex = 2;
            this.btnRemoveTeacher.Text = "Удалить преподавателя";
            this.btnRemoveTeacher.Click += new System.EventHandler(this.BtnRemoveTeacher_Click);
            // 
            // ManageTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lstTeachers);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnRemoveTeacher);
            this.Name = "ManageTeachers";
            this.Text = "Управление преподавателями";
            this.ResumeLayout(false);

        }

        #endregion
    }
}