using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database.Models {
    public class Schedule {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Classroom { get; set; }
        public Course Course { get; set; }
    }
}
