using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages.Admin {
    partial class AddStudent {
        private TextBox txtStudentName;
        private TextBox txtStudentSurname;
        private TextBox txtStudentEmail;
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "AddStudent";

            this.txtStudentName = new TextBox();
            this.txtStudentSurname = new TextBox();
            this.txtStudentEmail = new TextBox();
            this.btnSave = new Button(); 
            this.txtStudentName.Location = new System.Drawing.Point(12, 12);
            this.txtStudentName.Size = new System.Drawing.Size(260, 20);
            this.txtStudentName.Text = "Имя студента"; 
            this.txtStudentSurname.Location = new System.Drawing.Point(12, 42);
            this.txtStudentSurname.Size = new System.Drawing.Size(260, 20);
            this.txtStudentSurname.Text = "Фамилия студента";
            this.txtStudentEmail.Location = new System.Drawing.Point(12, 72); 
            this.txtStudentEmail.Size = new System.Drawing.Size(260, 20);
            this.txtStudentEmail.Text = "Email студента";
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(12, 132);
            this.btnSave.Click += new EventHandler(this.BtnSave_Click);
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.btnSave);
            this.Text = "Добавить студента";
        }

        #endregion
    }
}