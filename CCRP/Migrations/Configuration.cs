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
                new Coach {NameFull="Geneva Europa", JobTitle = "Instr Coach Math Common Core", EmailAddress ="geneva.europa@aspirepublicschools.org", ProfileImgUrl = "geuropa.png", Subject_ID =3}, 
                new Coach {NameFull="Amy Youngman", JobTitle = "Coach, Instructional", EmailAddress ="amy.youngman@aspirepublicschools.org", ProfileImgUrl = "acook.png", Subject_ID =4}, 
                new Coach {NameFull="Adam Krusi-Thom", JobTitle = "Coach, Instructional", EmailAddress ="Adam.Krusi-Thom@aspirepublicschools.org", ProfileImgUrl = "akrusithom.png", Subject_ID =4}, 
                new Coach {NameFull="Jennifer Nguyen", JobTitle = "Dir Instr. Coaching", EmailAddress ="Jennifer.Nguyen@aspirepublicschools.org", ProfileImgUrl = "jnguyen.png", Subject_ID =4},
                new Coach {NameFull="Rosario Parra", JobTitle = "Coach, Instructional", EmailAddress ="Rosario.Parra@aspirepublicschools.org", ProfileImgUrl = "rparra.png", Subject_ID =4}, 
                new Coach {NameFull="Michael Pease", JobTitle = "Dir Instr. Coaching", EmailAddress ="Michael.Pease@aspirepublicschools.org", ProfileImgUrl = "mpease.png", Subject_ID =3}, 
                new Coach {NameFull="Catherine Arenson", JobTitle = "Coach, Instructional", EmailAddress ="Catherine.Arenson@aspirepublicschools.org", ProfileImgUrl = "carenson.png", Subject_ID =3}, 
                new Coach {NameFull="Veronica Caldera", JobTitle = "Coach, Instructional", EmailAddress ="Veronica.Caldera@aspirepublicschools.org", ProfileImgUrl = "vcaldera.png", Subject_ID =3}, 
                new Coach {NameFull="Jennifer Marchy", JobTitle = "Coach, Instructional", EmailAddress ="Jennifer.Marchy@aspirepublicschools.org", ProfileImgUrl = "jmarchy.png", Subject_ID =4}, 
                new Coach {NameFull="Nate Monley", JobTitle = "Dir Teach Res Instr Coach", EmailAddress ="Nate.Monley@aspirepublicschools.org", ProfileImgUrl = "nmonley.png", Subject_ID =1}, 
                new Coach {NameFull="Niky Hunt", JobTitle = "Coach, Instructional", EmailAddress ="Niky.Hunt@aspirepublicschools.org", ProfileImgUrl = "nhunt.png", Subject_ID =1}, 
                new Coach {NameFull="Thomas McGrail", JobTitle = "Coach, Instructional", EmailAddress ="Thomas.McGrail@aspirepublicschools.org", ProfileImgUrl = "tmcGrail.png", Subject_ID =1}, 
                new Coach {NameFull="Susan Tabrah", JobTitle = "Coach, Instructional", EmailAddress ="Susan.Tabrah@aspirepublicschools.org", ProfileImgUrl = "stabrah.png", Subject_ID =1}, 
                new Coach {NameFull="Sharon Parker", JobTitle = "Coach, Instructional", EmailAddress ="Sharon.Parker@aspirepublicschools.org", ProfileImgUrl = "sparker.png", Subject_ID =5}, 
                //new Coach {NameFull="Jennifer Nguyen", JobTitle = "Dir Instr. Coaching", EmailAddress ="Jennifer.Nguyen@aspirepublicschools.org", ProfileImgUrl = "jnguyen.png", Subject_ID =2}, 
                new Coach {NameFull="Alicia De Santiago", JobTitle = "Induction Program Mgr", EmailAddress ="Alicia.DeSantiago@aspirepublicschools.org", ProfileImgUrl = "adesantiago.png", Subject_ID =2}, 
                new Coach {NameFull="Dawn Barnes", JobTitle = "Coach, Instructional", EmailAddress ="Dawn.Barnes@aspirepublicschools.org", ProfileImgUrl = "dbarnes.png", Subject_ID =2}, 
                new Coach {NameFull="Jessica Elway", JobTitle = "Instr Coach ELA Comm Core", EmailAddress ="Jessie.Elway@aspirepublicschools.org", ProfileImgUrl = "jelway.png", Subject_ID =2}, 
                new Coach {NameFull="Leilani Lafaurie", JobTitle = "Instr Coach ELA Comm Core", EmailAddress ="Leilani.Lafaurie@aspirepublicschools.org", ProfileImgUrl = "llafaurie.png", Subject_ID =2}
                );
        }
    }
}
