namespace UniversityProje
{
    partial class AdminForm
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
            this.CourcePanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupPanel = new System.Windows.Forms.Panel();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddGroup = new System.Windows.Forms.TextBox();
            this.SubjectPanel = new System.Windows.Forms.Panel();
            this.butAddSubject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.TeacherPanel = new System.Windows.Forms.Panel();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTeachIdent = new System.Windows.Forms.TextBox();
            this.txtTeachSurnam = new System.Windows.Forms.TextBox();
            this.txtTeachName = new System.Windows.Forms.TextBox();
            this.txtTeachPass = new System.Windows.Forms.TextBox();
            this.txtTeachComfPass = new System.Windows.Forms.TextBox();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudGroup = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtStudIdent = new System.Windows.Forms.TextBox();
            this.txtStudSurnam = new System.Windows.Forms.TextBox();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtStudPass = new System.Windows.Forms.TextBox();
            this.txtStudComfPass = new System.Windows.Forms.TextBox();
            this.btnAddTeachers = new System.Windows.Forms.Button();
            this.btnAddGroups = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnAddCouce = new System.Windows.Forms.Button();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CourcePanel.SuspendLayout();
            this.GroupPanel.SuspendLayout();
            this.SubjectPanel.SuspendLayout();
            this.TeacherPanel.SuspendLayout();
            this.StudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CourcePanel);
            this.panel1.Controls.Add(this.GroupPanel);
            this.panel1.Controls.Add(this.SubjectPanel);
            this.panel1.Controls.Add(this.TeacherPanel);
            this.panel1.Controls.Add(this.StudentPanel);
            this.panel1.Controls.Add(this.btnAddTeachers);
            this.panel1.Controls.Add(this.btnAddGroups);
            this.panel1.Controls.Add(this.btnAddSubject);
            this.panel1.Controls.Add(this.btnAddCouce);
            this.panel1.Controls.Add(this.btnAddStudents);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 452);
            this.panel1.TabIndex = 4;
            // 
            // CourcePanel
            // 
            this.CourcePanel.Controls.Add(this.label12);
            this.CourcePanel.Controls.Add(this.label11);
            this.CourcePanel.Controls.Add(this.cmbTeacher);
            this.CourcePanel.Controls.Add(this.cmbSubject);
            this.CourcePanel.Controls.Add(this.cmbGroup);
            this.CourcePanel.Controls.Add(this.button5);
            this.CourcePanel.Controls.Add(this.label10);
            this.CourcePanel.Location = new System.Drawing.Point(0, 313);
            this.CourcePanel.Name = "CourcePanel";
            this.CourcePanel.Size = new System.Drawing.Size(571, 232);
            this.CourcePanel.TabIndex = 21;
            this.CourcePanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(402, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Teacher";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Subject";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(399, 44);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(155, 21);
            this.cmbTeacher.TabIndex = 22;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(215, 44);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(155, 21);
            this.cmbSubject.TabIndex = 21;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(19, 44);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(155, 21);
            this.cmbGroup.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(16, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 36);
            this.button5.TabIndex = 19;
            this.button5.Text = "Add ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Group";
            // 
            // GroupPanel
            // 
            this.GroupPanel.Controls.Add(this.btnAddGroup);
            this.GroupPanel.Controls.Add(this.label14);
            this.GroupPanel.Controls.Add(this.txtAddGroup);
            this.GroupPanel.Location = new System.Drawing.Point(651, 261);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Size = new System.Drawing.Size(571, 232);
            this.GroupPanel.TabIndex = 20;
            this.GroupPanel.Visible = false;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.Maroon;
            this.btnAddGroup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddGroup.Location = new System.Drawing.Point(16, 97);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(195, 36);
            this.btnAddGroup.TabIndex = 19;
            this.btnAddGroup.Text = "Add ";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Name";
            // 
            // txtAddGroup
            // 
            this.txtAddGroup.Location = new System.Drawing.Point(16, 44);
            this.txtAddGroup.Multiline = true;
            this.txtAddGroup.Name = "txtAddGroup";
            this.txtAddGroup.Size = new System.Drawing.Size(155, 21);
            this.txtAddGroup.TabIndex = 8;
            // 
            // SubjectPanel
            // 
            this.SubjectPanel.Controls.Add(this.butAddSubject);
            this.SubjectPanel.Controls.Add(this.label3);
            this.SubjectPanel.Controls.Add(this.txtSubjectName);
            this.SubjectPanel.Location = new System.Drawing.Point(514, 11);
            this.SubjectPanel.Name = "SubjectPanel";
            this.SubjectPanel.Size = new System.Drawing.Size(571, 232);
            this.SubjectPanel.TabIndex = 21;
            this.SubjectPanel.Visible = false;
            // 
            // butAddSubject
            // 
            this.butAddSubject.BackColor = System.Drawing.Color.Maroon;
            this.butAddSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butAddSubject.Location = new System.Drawing.Point(16, 97);
            this.butAddSubject.Name = "butAddSubject";
            this.butAddSubject.Size = new System.Drawing.Size(195, 36);
            this.butAddSubject.TabIndex = 19;
            this.butAddSubject.Text = "Add ";
            this.butAddSubject.UseVisualStyleBackColor = false;
            this.butAddSubject.Click += new System.EventHandler(this.butAddSubject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(16, 44);
            this.txtSubjectName.Multiline = true;
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(155, 21);
            this.txtSubjectName.TabIndex = 8;
            // 
            // TeacherPanel
            // 
            this.TeacherPanel.Controls.Add(this.btnAddTeacher);
            this.TeacherPanel.Controls.Add(this.label4);
            this.TeacherPanel.Controls.Add(this.label5);
            this.TeacherPanel.Controls.Add(this.label6);
            this.TeacherPanel.Controls.Add(this.label7);
            this.TeacherPanel.Controls.Add(this.label8);
            this.TeacherPanel.Controls.Add(this.label9);
            this.TeacherPanel.Controls.Add(this.txtTeachIdent);
            this.TeacherPanel.Controls.Add(this.txtTeachSurnam);
            this.TeacherPanel.Controls.Add(this.txtTeachName);
            this.TeacherPanel.Controls.Add(this.txtTeachPass);
            this.TeacherPanel.Controls.Add(this.txtTeachComfPass);
            this.TeacherPanel.Location = new System.Drawing.Point(416, 297);
            this.TeacherPanel.Name = "TeacherPanel";
            this.TeacherPanel.Size = new System.Drawing.Size(571, 232);
            this.TeacherPanel.TabIndex = 19;
            this.TeacherPanel.Visible = false;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.Maroon;
            this.btnAddTeacher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddTeacher.Location = new System.Drawing.Point(16, 182);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(195, 36);
            this.btnAddTeacher.TabIndex = 19;
            this.btnAddTeacher.Text = "Add ";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Identifikator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Surname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Name";
            // 
            // txtTeachIdent
            // 
            this.txtTeachIdent.Location = new System.Drawing.Point(399, 44);
            this.txtTeachIdent.Multiline = true;
            this.txtTeachIdent.Name = "txtTeachIdent";
            this.txtTeachIdent.Size = new System.Drawing.Size(155, 21);
            this.txtTeachIdent.TabIndex = 10;
            // 
            // txtTeachSurnam
            // 
            this.txtTeachSurnam.Location = new System.Drawing.Point(215, 44);
            this.txtTeachSurnam.Multiline = true;
            this.txtTeachSurnam.Name = "txtTeachSurnam";
            this.txtTeachSurnam.Size = new System.Drawing.Size(155, 21);
            this.txtTeachSurnam.TabIndex = 9;
            // 
            // txtTeachName
            // 
            this.txtTeachName.Location = new System.Drawing.Point(16, 44);
            this.txtTeachName.Multiline = true;
            this.txtTeachName.Name = "txtTeachName";
            this.txtTeachName.Size = new System.Drawing.Size(155, 21);
            this.txtTeachName.TabIndex = 8;
            // 
            // txtTeachPass
            // 
            this.txtTeachPass.Location = new System.Drawing.Point(16, 129);
            this.txtTeachPass.Multiline = true;
            this.txtTeachPass.Name = "txtTeachPass";
            this.txtTeachPass.Size = new System.Drawing.Size(155, 21);
            this.txtTeachPass.TabIndex = 7;
            // 
            // txtTeachComfPass
            // 
            this.txtTeachComfPass.Location = new System.Drawing.Point(215, 129);
            this.txtTeachComfPass.Multiline = true;
            this.txtTeachComfPass.Name = "txtTeachComfPass";
            this.txtTeachComfPass.Size = new System.Drawing.Size(155, 21);
            this.txtTeachComfPass.TabIndex = 4;
            // 
            // StudentPanel
            // 
            this.StudentPanel.Controls.Add(this.label2);
            this.StudentPanel.Controls.Add(this.txtStudGroup);
            this.StudentPanel.Controls.Add(this.btnAddStudent);
            this.StudentPanel.Controls.Add(this.label16);
            this.StudentPanel.Controls.Add(this.label17);
            this.StudentPanel.Controls.Add(this.label18);
            this.StudentPanel.Controls.Add(this.label19);
            this.StudentPanel.Controls.Add(this.label20);
            this.StudentPanel.Controls.Add(this.label21);
            this.StudentPanel.Controls.Add(this.txtStudIdent);
            this.StudentPanel.Controls.Add(this.txtStudSurnam);
            this.StudentPanel.Controls.Add(this.txtStudName);
            this.StudentPanel.Controls.Add(this.txtStudPass);
            this.StudentPanel.Controls.Add(this.txtStudComfPass);
            this.StudentPanel.Location = new System.Drawing.Point(50, 56);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(571, 232);
            this.StudentPanel.TabIndex = 18;
            this.StudentPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Group";
            // 
            // txtStudGroup
            // 
            this.txtStudGroup.FormattingEnabled = true;
            this.txtStudGroup.Location = new System.Drawing.Point(399, 129);
            this.txtStudGroup.Name = "txtStudGroup";
            this.txtStudGroup.Size = new System.Drawing.Size(155, 21);
            this.txtStudGroup.TabIndex = 20;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Maroon;
            this.btnAddStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStudent.Location = new System.Drawing.Point(16, 182);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(195, 36);
            this.btnAddStudent.TabIndex = 19;
            this.btnAddStudent.Text = "Add ";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(212, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Confirm Password";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(396, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Identifikator";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(396, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(212, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "Surname";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 17);
            this.label21.TabIndex = 11;
            this.label21.Text = "Name";
            // 
            // txtStudIdent
            // 
            this.txtStudIdent.Location = new System.Drawing.Point(399, 44);
            this.txtStudIdent.Multiline = true;
            this.txtStudIdent.Name = "txtStudIdent";
            this.txtStudIdent.Size = new System.Drawing.Size(155, 21);
            this.txtStudIdent.TabIndex = 10;
            // 
            // txtStudSurnam
            // 
            this.txtStudSurnam.Location = new System.Drawing.Point(215, 44);
            this.txtStudSurnam.Multiline = true;
            this.txtStudSurnam.Name = "txtStudSurnam";
            this.txtStudSurnam.Size = new System.Drawing.Size(155, 21);
            this.txtStudSurnam.TabIndex = 9;
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(16, 44);
            this.txtStudName.Multiline = true;
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(155, 21);
            this.txtStudName.TabIndex = 8;
            // 
            // txtStudPass
            // 
            this.txtStudPass.Location = new System.Drawing.Point(16, 129);
            this.txtStudPass.Multiline = true;
            this.txtStudPass.Name = "txtStudPass";
            this.txtStudPass.Size = new System.Drawing.Size(155, 21);
            this.txtStudPass.TabIndex = 7;
            // 
            // txtStudComfPass
            // 
            this.txtStudComfPass.Location = new System.Drawing.Point(215, 129);
            this.txtStudComfPass.Multiline = true;
            this.txtStudComfPass.Name = "txtStudComfPass";
            this.txtStudComfPass.Size = new System.Drawing.Size(155, 21);
            this.txtStudComfPass.TabIndex = 4;
            // 
            // btnAddTeachers
            // 
            this.btnAddTeachers.BackColor = System.Drawing.Color.Maroon;
            this.btnAddTeachers.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeachers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddTeachers.Location = new System.Drawing.Point(16, 142);
            this.btnAddTeachers.Name = "btnAddTeachers";
            this.btnAddTeachers.Size = new System.Drawing.Size(192, 50);
            this.btnAddTeachers.TabIndex = 15;
            this.btnAddTeachers.Text = "Add Teacher";
            this.btnAddTeachers.UseVisualStyleBackColor = false;
            this.btnAddTeachers.Click += new System.EventHandler(this.btnAddTeachers_Click);
            // 
            // btnAddGroups
            // 
            this.btnAddGroups.BackColor = System.Drawing.Color.Maroon;
            this.btnAddGroups.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroups.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddGroups.Location = new System.Drawing.Point(16, 218);
            this.btnAddGroups.Name = "btnAddGroups";
            this.btnAddGroups.Size = new System.Drawing.Size(192, 50);
            this.btnAddGroups.TabIndex = 14;
            this.btnAddGroups.Text = "Add Group";
            this.btnAddGroups.UseVisualStyleBackColor = false;
            this.btnAddGroups.Click += new System.EventHandler(this.btnAddGroups_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.Maroon;
            this.btnAddSubject.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSubject.Location = new System.Drawing.Point(16, 292);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(192, 50);
            this.btnAddSubject.TabIndex = 13;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnAddCouce
            // 
            this.btnAddCouce.BackColor = System.Drawing.Color.Maroon;
            this.btnAddCouce.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCouce.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCouce.Location = new System.Drawing.Point(16, 367);
            this.btnAddCouce.Name = "btnAddCouce";
            this.btnAddCouce.Size = new System.Drawing.Size(192, 50);
            this.btnAddCouce.TabIndex = 12;
            this.btnAddCouce.Text = "Add Course";
            this.btnAddCouce.UseVisualStyleBackColor = false;
            this.btnAddCouce.Click += new System.EventHandler(this.btnAddCouce_Click);
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.BackColor = System.Drawing.Color.Maroon;
            this.btnAddStudents.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStudents.Location = new System.Drawing.Point(16, 71);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(192, 50);
            this.btnAddStudents.TabIndex = 11;
            this.btnAddStudents.Text = "Add Student";
            this.btnAddStudents.UseVisualStyleBackColor = false;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 497);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.CourcePanel.ResumeLayout(false);
            this.CourcePanel.PerformLayout();
            this.GroupPanel.ResumeLayout(false);
            this.GroupPanel.PerformLayout();
            this.SubjectPanel.ResumeLayout(false);
            this.SubjectPanel.PerformLayout();
            this.TeacherPanel.ResumeLayout(false);
            this.TeacherPanel.PerformLayout();
            this.StudentPanel.ResumeLayout(false);
            this.StudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTeachers;
        private System.Windows.Forms.Button btnAddGroups;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnAddCouce;
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtStudSurnam;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.TextBox txtStudPass;
        private System.Windows.Forms.TextBox txtStudComfPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtStudGroup;
        private System.Windows.Forms.Panel TeacherPanel;
        private System.Windows.Forms.Panel GroupPanel;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddGroup;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTeachIdent;
        private System.Windows.Forms.TextBox txtTeachSurnam;
        private System.Windows.Forms.TextBox txtTeachName;
        private System.Windows.Forms.TextBox txtTeachPass;
        private System.Windows.Forms.TextBox txtTeachComfPass;
        private System.Windows.Forms.Panel SubjectPanel;
        private System.Windows.Forms.Button butAddSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Panel CourcePanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtStudIdent;
    }
}