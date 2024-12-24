using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages.Admin {
    partial class AddTeacher {
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtPassword;
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
            this.Text = "AddTeacher";

            this.txtName = new TextBox();
            this.txtSurname = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.btnSave = new Button();
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.Text = "Имя";
            this.txtSurname.Location = new System.Drawing.Point(12, 42);
            this.txtSurname.Size = new System.Drawing.Size(260, 20);
            this.txtSurname.Text = "Фамилия";
            this.txtEmail.Location = new System.Drawing.Point(12, 72);
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.Text = "Email"; 
            this.txtPassword.Location = new System.Drawing.Point(12, 102);
            this.txtPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPassword.Text = "Пароль";
            this.txtPassword.PasswordChar = '*'; 
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(12, 132);
            this.btnSave.Click += new EventHandler(this.BtnSave_Click); 
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSave);
            this.Text = "Добавить преподавателя";
        }

        #endregion
    }
}