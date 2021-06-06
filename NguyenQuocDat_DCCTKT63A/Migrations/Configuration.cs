using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace NguyenQuocDat_DCCTKT63A.Migrations
{
    public class Configuration : DbMigrationsConfiguration<NguyenQuocDat_DCCTKT63A.Models.LTQLDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NguyenQuocDat_DCCTKT63A.Models.LTQLDbContext context)
        {

        }
    }
}