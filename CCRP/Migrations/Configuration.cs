namespace CCRP.Migrations
{
using CCRP.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CCRP.Models.CCRPdb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CCRP.Models.CCRPdb context)
        {
            context.Subjects.AddOrUpdate(s => s.Title,
                new Subject { Title = "K-5 Math" },
                new Subject { Title = "K-5 ELA" },
                new Subject { Title = "6-12 Math" },
                new Subject { Title = "6-12 Humanities" },
                new Subject { Title = "Science" }
                );

            context.Coaches.AddOrUpdate(c => c.NameFull,
                new Coach {NameFull="Geneva Europa", JobTitle = "Instr Coach Common Core", EmailAddress ="geneva.europa@aspirepublicschools.org", ProfileImgUrl = "geuropa.jpg", Subject_ID =3}, 
                new Coach {NameFull="Amy Youngman", JobTitle = "Coach, Instructional", EmailAddress ="amy.youngman@aspirepublicschools.org", ProfileImgUrl = "acook.jpg", Subject_ID =4} 
                );
        }
    }
}
