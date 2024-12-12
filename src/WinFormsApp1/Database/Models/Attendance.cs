﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database.Models {
    public class Attendance {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Presence { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
