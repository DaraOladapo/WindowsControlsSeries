using ListView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView.ViewModel
{
   class EmployeeViewModel
    {
        List<Employee> EmployeeList = new List<Employee>();
        public List<Employee> GetEmployee()
       {
            //I'll use a loop to add 5 Employee
            //add your code as you want to
            for (int i = 0; i < 5; i++)
            {
                EmployeeList.Add(new Employee() { Name = "Mark Duke", Phone = "123456789", ImagePath = "/Images/User.png" });
            }

            return EmployeeList; 
        }
    }
}
