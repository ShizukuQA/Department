﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database.Models {
    public class Performance {
        public int Id { get; set; }
        public string Assessment { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
