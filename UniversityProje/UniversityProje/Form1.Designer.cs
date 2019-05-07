namespace UniversityProje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdrTeacher = new System.Windows.Forms.RadioButton();
            this.rdrStudent = new System.Windows.Forms.RadioButton();
            this.rdrAdmin = new System.Windows.Forms.RadioButton();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdrTeacher);
            this.panel1.Controls.Add(this.rdrStudent);
            this.panel1.Controls.Add(this.rdrAdmin);
            this.panel1.Controls.Add(this.txtIdent);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 471);
            this.panel1.TabIndex = 3;
            // 
            // rdrTeacher
            // 
            this.rdrTeacher.AutoSize = true;
            this.rdrTeacher.Location = new System.Drawing.Point(158, 293);
            this.rdrTeacher.Name = "rdrTeacher";
            this.rdrTeacher.Size = new System.Drawing.Size(65, 17);
            this.rdrTeacher.TabIndex = 17;
            this.rdrTeacher.TabStop = true;
            this.rdrTeacher.Text = "Teacher";
            this.rdrTeacher.UseVisualStyleBackColor = true;
            // 
            // rdrStudent
            // 
            this.rdrStudent.AutoSize = true;
            this.rdrStudent.Location = new System.Drawing.Point(264, 293);
            this.rdrStudent.Name = "rdrStudent";
            this.rdrStudent.Size = new System.Drawing.Size(62, 17);
            this.rdrStudent.TabIndex = 16;
            this.rdrStudent.TabStop = true;
            this.rdrStudent.Text = "Student";
            this.rdrStudent.UseVisualStyleBackColor = true;
            // 
            // rdrAdmin
            // 
            this.rdrAdmin.AutoSize = true;
            this.rdrAdmin.Location = new System.Drawing.Point(56, 293);
            this.rdrAdmin.Name = "rdrAdmin";
            this.rdrAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdrAdmin.TabIndex = 15;
            this.rdrAdmin.TabStop = true;
            this.rdrAdmin.Text = "Admin";
            this.rdrAdmin.UseVisualStyleBackColor = true;
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(56, 147);
            this.txtIdent.Multiline = true;
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(270, 30);
            this.txtIdent.TabIndex = 14;
            this.txtIdent.Text = "Admin";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(56, 234);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(270, 30);
            this.txtPass.TabIndex = 13;
            this.txtPass.Text = "Admin123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Identifikator";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(56, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 50);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 471);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdrTeacher;
        private System.Windows.Forms.RadioButton rdrStudent;
        private System.Windows.Forms.RadioButton rdrAdmin;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.TextBox txtPass;
    }
}

