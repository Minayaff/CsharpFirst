using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProje
{
    class ComboItem
    {

        public int Value { get; set; }
        public String Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
