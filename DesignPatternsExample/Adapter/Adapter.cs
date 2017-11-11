using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : ITarget
    {
        public List<string> GetEmployee()
        {
            List<string> employee = new List<string>();

            string[][] empList = new Adaptee().GetEmployees();
            foreach(string[] emp in empList)
            {
                employee.Add(emp[1]);
            }

            return employee;
        }
    }
}
