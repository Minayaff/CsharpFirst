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
    public partial class TeacherForm : Form
    {
        CsharpProjeEntities1 db = new CsharpProjeEntities1();
        public TeacherForm(Form1 form1)
        {
            InitializeComponent();
        }

       

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            cmbstudent.DataSource = db.Students.Select(z => new ComboItem
            {
                Text = z.Sname,
                Value = z.ID
            }).ToList();


            //cmbgroup.DataSource = db.Groups.Select(v => new ComboItem
            //{
            //    Text = v.Gname,
            //    Value = v.ID
            //}).ToList();


            cmbsubject.DataSource = db.Subjects.Select(d => new ComboItem
            {
                Text = d.Subjname,
                Value = d.ID
            }).ToList();

            cmbpoint.DataSource = db.Points.Select(l => new ComboItem
            {
                Text = l.PointRes,
                Value = l.ID
            }).ToList();
        }

        private void teachAdd_Click(object sender, EventArgs e)
        {
            Grade newgrade = new Grade();

            ComboItem gr = cmbstudent.SelectedItem as ComboItem;
            newgrade.StudentID = gr.Value;

            //ComboItem group = cmbgroup.SelectedItem as ComboItem;
            //newgrade.G = group.Value;

            ComboItem sub = cmbsubject.SelectedItem as ComboItem;
            newgrade.SubjectID = sub.Value;

            ComboItem po = cmbpoint.SelectedItem as ComboItem;
            newgrade.Point = po.Value;

            db.Grades.Add(newgrade);
            db.SaveChanges();
            MessageBox.Show(  "The student was evaluated");
        }
    }
}
