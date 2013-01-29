using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class library
    {
        public bool checkOdd(int number)
        {
            if(number%2==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
