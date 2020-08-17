using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HANMISYSTEM.Module
{
    class Isnumber
    {
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public bool IsPositive(string str)
        {
            bool check = false;
            if(IsNumber(str))
            {
                if(Convert.ToInt32(str)>0)
                {
                    check= true;
                }
                else
                {
                    check = false;
                }
            }
            else
            {
                check= false;
            }
            return check;
        }
    }
}
