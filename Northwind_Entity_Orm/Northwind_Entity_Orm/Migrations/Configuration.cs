using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Entity_Orm.Migrations
{
    internal sealed class Configuration: DbMigrationsConfiguration<Northwind_Entity_Orm.DAL.ORM.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Northwind_Entity_Orm.DAL.ORM.Context.ProjectContext context)
        {

        }

    }
}
