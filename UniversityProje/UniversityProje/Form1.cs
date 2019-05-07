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
    public partial class Form1 : Form
    {
        CsharpProjeEntities1 db = new CsharpProjeEntities1();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {


            RadioButton rb = null;
            if (rdrAdmin.Checked ==true)
            {
                rb = rdrAdmin;
                string Password = txtPass.Text.Trim();
                string DefaultPass = Properties.Settings.Default.Password;
                string Identifikator = txtIdent.Text.Trim();
                string DefaultIdent = Properties.Settings.Default.Admin;

                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Identifikator) || Password != DefaultPass || Identifikator != DefaultIdent)
                {
                    MessageBox.Show("Password is wrong.");
                    return;
                }
                txtPass.Text = "";
                MessageBox.Show("Admin Login Succesfully");
                new AdminForm(this).ShowDialog();

            }
           
            
            if (rdrStudent.Checked==true)
            {
                rb = rdrStudent;
                int txt = Convert.ToInt32(txtIdent.Text);
                Student student = db.Students.FirstOrDefault(u => (u.ID == txt) 
                && (u.Sparol== txtPass.Text));

            if (txt != null && txtPass.Text != null)
            {
                if (txt == student.ID && txtPass.Text == student.Sparol)
                {
                    MessageBox.Show("YOUR ACCESS IS  SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("YOUR ACCESS IS NOT SUCCESSFULLY");
                    return;
                }

            }
                txtPass.Text = "";
                new StudentFormm(this).ShowDialog();
            }




            if (rdrTeacher.Checked == true)
            {
                rb = rdrTeacher;
                int txtx = Convert.ToInt32(txtIdent.Text);
                Teacher teacher = db.Teachers.FirstOrDefault(g => (g.ID == txtx)
                && (g.Tparol == txtPass.Text));

                if (txtx != null && txtPass.Text != null)
                {
                    if (txtx == teacher.ID && txtPass.Text == teacher.Tparol)
                    {
                        MessageBox.Show("YOUR ACCESS IS  SUCCESSFULLY");
                    }
                    else
                    {
                        MessageBox.Show("YOUR ACCESS IS NOT SUCCESSFULLY");
                        return;
                    }

                }
                txtPass.Text = "";
                new TeacherForm(this).ShowDialog();
            }




        }
    }
}
