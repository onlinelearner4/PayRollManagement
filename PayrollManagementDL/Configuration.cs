using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementDL
{
    public sealed class Configuration: DbMigrationsConfiguration<AppDdbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(AppDdbContext context)
        {
            base.Seed(context);
        }
    }
}
