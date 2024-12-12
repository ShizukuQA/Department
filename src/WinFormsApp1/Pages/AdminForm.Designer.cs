using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages {
    partial class AdminForm {
        private Button btnCreateCourse;
        private Button btnAddStudent;
        private Button btnEditSchedule;
        private Button btnManageTeachers;

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
            this.btnCreateCourse = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnManageTeachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Location = new System.Drawing.Point(12, 12);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(225, 23);
            this.btnCreateCourse.TabIndex = 0;
            this.btnCreateCourse.Text = "Создать курс";
            this.btnCreateCourse.Click += new System.EventHandler(this.BtnCreateCourse_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 42);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(225, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Добавить студента";
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.Location = new System.Drawing.Point(12, 72);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(225, 23);
            this.btnEditSchedule.TabIndex = 2;
            this.btnEditSchedule.Text = "Редактировать расписание";
            this.btnEditSchedule.Click += new System.EventHandler(this.BtnEditSchedule_Click);
            // 
            // btnManageTeachers
            // 
            this.btnManageTeachers.Location = new System.Drawing.Point(12, 102);
            this.btnManageTeachers.Name = "btnManageTeachers";
            this.btnManageTeachers.Size = new System.Drawing.Size(225, 23);
            this.btnManageTeachers.TabIndex = 3;
            this.btnManageTeachers.Text = "Управление преподавателями";
            this.btnManageTeachers.Click += new System.EventHandler(this.BtnManageTeachers_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnCreateCourse);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnEditSchedule);
            this.Controls.Add(this.btnManageTeachers);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.ResumeLayout(false);

        }

        #endregion
    }
}