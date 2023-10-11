using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementDL
{
    public class AppDdbContext:DbContext
    {
        public AppDdbContext() : base("appcon")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
