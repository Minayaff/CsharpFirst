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
    public partial class StudentFormm : Form
    {
        CsharpProjeEntities1 db = new CsharpProjeEntities1();
        public StudentFormm(Form1 form1)
        {
            InitializeComponent();
        }

      


        private void UpdateDtg()
        {
            dataGrid.DataSource = db.Grades.Select(m => new {
                Name=m.Student.Sname,
                Surname= m.Student.Ssurname,
                Point= m.Point,
                Subject= m.Subject.Subjname
          
            }).ToList();
        }

        private void StudentFormm_Load(object sender, EventArgs e)
        {
            UpdateDtg();
        }
    }
}
