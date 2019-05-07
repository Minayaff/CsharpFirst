using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityProje.Model;

namespace UniversityProje
{
    public partial class AdminForm : Form
    {
        CsharpProjeEntities1 db = new CsharpProjeEntities1();
        private Form1 form1;
        public AdminForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }



        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = true;
            TeacherPanel.Visible = false;
            GroupPanel.Visible = false;
            SubjectPanel.Visible = false;
            CourcePanel.Visible = false;

            txtStudGroup.DataSource = db.Groups.Select(g => new ComboItem
            {
                Text = g.Gname,
                Value = g.ID
            }).ToList();
        }

        private void btnAddTeachers_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            TeacherPanel.Visible = true;
            GroupPanel.Visible = false;
            SubjectPanel.Visible = false;
            CourcePanel.Visible = false;
        }

        private void btnAddGroups_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            TeacherPanel.Visible = false;
            GroupPanel.Visible = true;
            SubjectPanel.Visible = false;
            CourcePanel.Visible = false;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            TeacherPanel.Visible = false;
            GroupPanel.Visible = false;
            SubjectPanel.Visible = true;
            CourcePanel.Visible = false;
        }

        private void btnAddCouce_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            TeacherPanel.Visible = false;
            GroupPanel.Visible = false;
            SubjectPanel.Visible = false;
            CourcePanel.Visible = true;

            cmbGroup.DataSource = db.Groups.Select(h => new ComboItem
            {
                Text = h.Gname,
                Value = h.ID
            }).ToList();



            cmbSubject.DataSource = db.Subjects.Select(r => new ComboItem
            {
                Text = r.Subjname,
                Value = r.ID
            }).ToList();

            cmbTeacher.DataSource = db.Teachers.Select(p => new ComboItem
            {
                Text = p.Tname,
                Value = p.ID
            }).ToList();
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            if (txtStudPass.Text==txtStudComfPass.Text)
            {
                Student newstudent = new Student();
                newstudent.Sname = txtStudName.Text;
                newstudent.Ssurname = txtStudSurnam.Text;
                //newstudent.StudentIdent = Convert.ToInt32(txtStudIdent.Text);

                newstudent.Sparol = txtStudPass.Text;
                ComboItem N = txtStudGroup.SelectedItem as ComboItem;
                newstudent.GroupId = N.Value;


                db.Students.Add(newstudent);
                db.SaveChanges();
                MessageBox.Show("Admin add Student Succesfully");
            }
            else
            {
                MessageBox.Show("Password is not correct");
            }

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Group newgroup = new Group();
            newgroup.Gname = txtAddGroup.Text.Trim();

            db.Groups.Add(newgroup);
            db.SaveChanges();
            MessageBox.Show("Admin add Group Succesfully");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            StudentPanel.Location = new System.Drawing.Point(235, 95);
            TeacherPanel.Location = new System.Drawing.Point(235, 95);
            GroupPanel.Location = new System.Drawing.Point(235, 95);
            SubjectPanel.Location = new System.Drawing.Point(235, 95);
            CourcePanel.Location = new System.Drawing.Point(235, 95);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (txtTeachPass.Text == txtTeachComfPass.Text )
            {
                Teacher newteacher = new Teacher();
                newteacher.Tname = txtTeachName.Text;
                newteacher.Tsurname = txtTeachSurnam.Text;
               // newteacher.Tidentifikator = Convert.ToInt32(txtTeachIdent.Text);
                newteacher.Tparol = txtTeachPass.Text;
                db.Teachers.Add(newteacher);
                db.SaveChanges();
                MessageBox.Show("Admin add Teacher Succesfully");
            }
            else
            {
                MessageBox.Show("not succesfully");
            }

        }

        private void butAddSubject_Click(object sender, EventArgs e)
        {
            Subject newsubject = new Subject();
            newsubject.Subjname = txtSubjectName.Text.Trim();
            db.Subjects.Add(newsubject);
            db.SaveChanges();
            MessageBox.Show("Admin add Subject Succesfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TSG newcource = new TSG();
            ComboItem m = cmbGroup.SelectedItem as ComboItem;
            newcource.GroupId = m.Value;

            ComboItem s = cmbTeacher.SelectedItem as ComboItem;
            newcource.TeacherID = s.Value;

            ComboItem f = cmbSubject.SelectedItem as ComboItem;
            newcource.SubjectId = f.Value;

            db.TSGs.Add(newcource);
            db.SaveChanges();
            MessageBox.Show("Admin add Cource Succesfully");

        }

      
    }
}
