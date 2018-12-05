using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIOraclDapper.Repository
{
    interface IEmployeeRepository
    {
        object GetEmployeeList();
        object GetEmployeeDetails(int empID);
    }
}
