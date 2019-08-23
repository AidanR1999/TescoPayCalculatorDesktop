using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoPayCalculater
{
    //small helper class to help convert values
    public static class Helper
    {
        //converts string to double, returns 0 if fail
        public static double ToDoubleDefaultZero(string v)
        {
            try
            {
                return Convert.ToDouble(v);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return 0;
        }
    }
}
