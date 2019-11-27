using System;
using System.Collections.Generic;
using System.Text;

namespace StudentForm.Core.Services
{
    public class CalculatorYService : ICalculatorService
    {
        public double StudentFormValues(double x1, double x2,double a, double b, double c)
        {
            x2 = (-b - (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
            return x2;
        }
    }
}
