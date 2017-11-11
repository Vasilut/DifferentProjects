using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ThirdPartySystem
    {
        private ITarget _target;
        public ThirdPartySystem(ITarget target)
        {
            _target = target;
        }

        public void ShowEmployee()
        {
            List<string> listOfEmployee = _target.GetEmployee();
            foreach (var item in listOfEmployee)
            {
                Console.WriteLine(item);
            }
        }
    }
}
