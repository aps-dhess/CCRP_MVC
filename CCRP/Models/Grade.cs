using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCRP.Models
{
    public class Grade
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int SubjectID { get; set; }
    }
}