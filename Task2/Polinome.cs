using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Polinome
    {
        public double[] CoefficientList { get; }
        public int Size { get; }

        public Polinome()
        {
            CoefficientList = new double[0];
            Size = CoefficientList.Length;
        }

        public Polinome(params double[] coefficientList)
        {
            CoefficientList = coefficientList;
            Size = CoefficientList.Length;
        }

        public Polinome(int size)
        {
            CoefficientList = new double[size];
            Size = size;
        }

        public static Polinome operator +(Polinome lhs, Polinome rhs)
        {
            return new Polinome();
        }
    }
}
