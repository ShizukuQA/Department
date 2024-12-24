using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages.Admin {
    partial class EditSchedule {
        private ComboBox cmbCourses;
        private DateTimePicker dtpDate;
        private TextBox txtRoom;
        private Button btnSave;
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
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCourses
            // 
            this.cmbCourses.Location = new System.Drawing.Point(12, 12);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(260, 21);
            this.cmbCourses.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 51);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(260, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(12, 89);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(260, 20);
            this.txtRoom.TabIndex = 3;
            this.txtRoom.Text = "Аудитория";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(103, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // EditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 205);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.btnSave);
            this.Name = "EditSchedule";
            this.Text = "Редактировать расписание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}