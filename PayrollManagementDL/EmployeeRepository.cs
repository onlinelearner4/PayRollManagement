using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementDL
{
    public class EmployeeRepository
    {
        AppDdbContext dbContext = new AppDdbContext();
        public int Add(Employee employee)
        {
            dbContext.Employees.Add(employee);
           return  dbContext.SaveChanges();

        }
        public int Update(Employee employee)
        {
            return 0;


        }
        public int Delete(int id)
        {
            return 0;
        }
    }
}
