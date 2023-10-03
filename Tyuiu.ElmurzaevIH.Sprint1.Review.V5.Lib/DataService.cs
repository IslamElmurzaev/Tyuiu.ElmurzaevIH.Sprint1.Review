using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElmurzaevIH.Sprint1.Review.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double numerator = Math.Log(Math.Abs(Math.Cos(x)));
            double denominator = Math.Log(1 + Math.Pow(x, 2));
            double res = Math.Round(numerator / denominator, 3);
            return res;
        }
    }
}
