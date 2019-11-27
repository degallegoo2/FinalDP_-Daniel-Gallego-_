using System;
using System.Collections.Generic;
using System.Text;

namespace StudentForm.Core.Services
{
    public class CalculatorXService : ICalculatorService
    {
        public double StudentFormValues(double x1, double x2,double a, double b, double c)
        {
            double formula = b * b - 4.0 * a * c;
            x1 = (-b + Math.Sqrt(formula)) / (2 * a);
            return x1;
        }
    }
}
