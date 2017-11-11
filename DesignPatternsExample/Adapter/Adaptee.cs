using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adaptee
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "2000", "Lucian", "Software Architect" };
            employees[1] = new string[] { "1500", "Alina", "Software Developer" };
            employees[2] = new string[] { "1300", "Andrei", "Software OPS" };
            employees[3] = new string[] { "1800", "Feli", "QA" };

            return employees;
        }
    }
}
