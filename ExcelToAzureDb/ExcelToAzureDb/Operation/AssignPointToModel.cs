using EntitiesAzure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToAzureDb.Operation
{
    public class AssignPointToModel
    {
        public static void  AssignProblemPoint(ref Rezultate model, object points)
        {
            if(model.P1 == 0)
            {
                model.P1 = Convert.ToInt32(points);
            }
            else
            if(model.P2 == 0)
            {
                model.P2 = Convert.ToInt32(points);
            }
            else
            {
                model.P3 = Convert.ToInt32(points);
            }


        }
    }
}
