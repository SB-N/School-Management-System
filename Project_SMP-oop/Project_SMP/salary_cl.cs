using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SMP
{
    class salary_cl
    {
        public int sl_id { get; set; }
        public string status { get; set; }
        public float Amount { get; set; }
       
        public string month { get; set; }
        public string year { get; set; }
        public Teacher_cl teacher { get; set; } = new Teacher_cl();
        public  int workD { get; set; }

      
    }
}
