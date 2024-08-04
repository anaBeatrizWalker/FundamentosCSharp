using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCSharp.Models
{
    public class Calculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potentiation(int x, int y)
        {
            double result = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {result}");
        }

        public void Sine(double angle)
        {
            double radian = angle * Math.PI / 180;
            double result = Math.Sin(radian);
            Console.WriteLine($"Seno de {angle}° = {Math.Round(result, 4)}");
        }

        public void Cosine(double angle)
        {
            double radian = angle * Math.PI / 180;
            double result = Math.Cos(radian);
            Console.WriteLine($"Coseno de {angle}° = {Math.Round(result, 4)}");
        }

        public void Tangent(double angle)
        {
            double radian = angle * Math.PI / 180;
            double result = Math.Tan(radian);
            Console.WriteLine($"Tangente de {angle}° = {Math.Round(result, 4)}");
        }

         public void SquareRoot(double x)
        {
            double result = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {result}");
        }
    }
}