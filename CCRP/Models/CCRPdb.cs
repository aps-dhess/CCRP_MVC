using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CCRP.Models
{
    public class CCRPdb : DbContext
    {
        public CCRPdb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }


    }
}