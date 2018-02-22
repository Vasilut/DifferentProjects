using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToAzureDb.Operation
{
    public class BuildDictionary
    {
        private Dictionary<string, string> _idToClass;
        public BuildDictionary()
        {
            _idToClass = new Dictionary<string, string>();
        }
        public Dictionary<string,string> GetDb()
        {
            //clasa a IX-a
            _idToClass["91"] = "IX";
            _idToClass["92"] = "IX";
            _idToClass["93"] = "IX";
            _idToClass["94"] = "IX";
            _idToClass["95"] = "IX";
            _idToClass["96"] = "IX";
            _idToClass["97"] = "IX";
            _idToClass["98"] = "IX";
            _idToClass["99"] = "IX";
            _idToClass["910"] = "IX";
            _idToClass["911"] = "IX";
            _idToClass["912"] = "IX";
            _idToClass["913"] = "IX";
            _idToClass["914"] = "IX";
            _idToClass["915"] = "IX";
            _idToClass["916"] = "IX";
            _idToClass["917"] = "IX";
            _idToClass["918"] = "IX";
            _idToClass["919"] = "IX";
            _idToClass["920"] = "IX";
            _idToClass["921"] = "IX";
            _idToClass["922"] = "IX";
            _idToClass["923"] = "IX";
            _idToClass["924"] = "IX";
            _idToClass["925"] = "IX";
            _idToClass["926"] = "IX";

            //Gimnaziu
            _idToClass["51"] = "VI";
            _idToClass["52"] = "VI";
            _idToClass["53"] = "VI";
            _idToClass["61"] = "VI";
            _idToClass["62"] = "VI";
            _idToClass["63"] = "VI";
            _idToClass["64"] = "VI";
            _idToClass["65"] = "VI";
            _idToClass["66"] = "VI";
            _idToClass["67"] = "VI";
            _idToClass["68"] = "VI";

            //clasa a X-a
            _idToClass["A1"] = "X";
            _idToClass["A2"] = "X";
            _idToClass["A3"] = "X";
            _idToClass["A4"] = "X";
            _idToClass["A5"] = "X";
            _idToClass["A6"] = "X";
            _idToClass["A7"] = "X";
            _idToClass["A8"] = "X";
            _idToClass["A9"] = "X";
            _idToClass["A10"] = "X";
            _idToClass["A11"] = "X";
            _idToClass["A12"] = "X";
            _idToClass["A13"] = "X";
            _idToClass["A14"] = "X";
            _idToClass["A15"] = "X";
            _idToClass["A16"] = "X";
            _idToClass["A17"] = "X";
            _idToClass["A18"] = "X";
            _idToClass["A19"] = "X";
            _idToClass["A20"] = "X";
            _idToClass["A21"] = "X";
            _idToClass["A22"] = "X";
            _idToClass["A23"] = "X";
            _idToClass["A24"] = "X";
            _idToClass["A25"] = "X";


            //clasa a XI-a
            _idToClass["B1"] = "XI";
            _idToClass["B2"] = "XI";
            _idToClass["B3"] = "XI";
            _idToClass["B4"] = "XI";
            _idToClass["B5"] = "XI";
            _idToClass["B6"] = "XI";
            _idToClass["B7"] = "XI";
            _idToClass["B8"] = "XI";
            _idToClass["B9"] = "XI";
            _idToClass["B10"] = "XI";
            _idToClass["B11"] = "XI";
            _idToClass["B12"] = "XI";
            _idToClass["B13"] = "XI";
            _idToClass["B14"] = "XI";
            _idToClass["B15"] = "XI";
            _idToClass["B16"] = "XI";
            _idToClass["B17"] = "XI";
            _idToClass["B18"] = "XI";

            //clasa a XII-a
            _idToClass["C1"] = "XII";
            _idToClass["C2"] = "XII";
            _idToClass["C3"] = "XII";
            _idToClass["C4"] = "XII";
            _idToClass["C5"] = "XII";
            _idToClass["C6"] = "XII";

            return _idToClass;
        }
    }
}
