using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCRP.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Coach> Coaches { get; set; }

    }
}