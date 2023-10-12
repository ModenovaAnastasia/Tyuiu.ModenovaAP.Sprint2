using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ModenovaAP.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y >= 0)
            {
                if (y <= 2 - x * x)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((y <= 2 - x * x) && (y >= x))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
