using PayrollManagementDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementBL
{
    public class EmployeeService
    {
        EmployeeRepository repo = new EmployeeRepository();
        public ResultResponse AddEmployee (Employee employee) 
        {
            int res= repo.Add(employee);
            if (res==1)
            {
                return new ResultResponse()
                {
                    ResultType = 1,
                    Result = "Sucess"
                };

            }
            else
            {
                return new ResultResponse()
                {
                    ResultType = 2,
                    Result = "Failed"
                };
            }
        }
    }
}
