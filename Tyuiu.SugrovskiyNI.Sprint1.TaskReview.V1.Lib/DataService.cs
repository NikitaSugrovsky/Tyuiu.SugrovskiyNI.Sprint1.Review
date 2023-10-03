using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SugrovskiyNI.Sprint1.TaskReview.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            double result = (b + Math.Sqrt(b * b + 4 * a * c)) / (2 * a) - a * a * a * c + Math.Pow(b, -2);
            double res = Math.Round(result, 3);
            return res;
        }
    }
}
