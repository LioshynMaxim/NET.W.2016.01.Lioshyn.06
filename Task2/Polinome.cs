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
        /// <summary>
        /// Coefficients & size array
        /// </summary>
        private double[] CoefficientList { get; }
        private int Size { get; }


        #region .ctor

        /// <summary>
        /// .ctor zero polinome
        /// </summary>

        public Polinome()
        {
            CoefficientList = new double[0];
            Size = CoefficientList.Length;
        }

        /// <summary>
        /// .ctor of array coefficients
        /// </summary>
        /// <param name="coefficientList">Array coefficients</param>

        public Polinome(params double[] coefficientList)
        {
            CoefficientList = coefficientList;
            Size = CoefficientList.Length;
        }

        /// <summary>
        /// .ctor of size array coefficients
        /// </summary>
        /// <param name="size">Size amount coefficients</param>

        public Polinome(int size)
        {
            CoefficientList = new double[size];
            Size = size;
        }

        #endregion

        #region Operation

        /// <summary>
        /// Binary plus. Summ two polinomes
        /// </summary>
        /// <param name="first">First polinome</param>
        /// <param name="second">Second polinome</param>
        /// <returns>The sum of polynomials</returns>

        public static Polinome operator +(Polinome first, Polinome second)
        {
            if (ReferenceEquals(null, first) || ReferenceEquals(null, second))
                throw new ArgumentNullException();

            Polinome polinome;
            double[] result;

            if (first.Size >= second.Size)
            {
                result = first.CoefficientList;
                polinome = second;
            }
            else
            {
                result = second.CoefficientList;
                polinome = first;
            }

            for (var i = 0; i < polinome.Size; i++)
            {
                result[i] += polinome[i];
            }

            return new Polinome(result);
        }

        /// <summary>
        /// Multiplu two polinomes without optimization of degree polynomial
        /// </summary>
        /// <param name="first">First polinome</param>
        /// <param name="second">Second polinome</param>
        /// <returns>The product of polynomials</returns>

        public static Polinome operator *(Polinome first, Polinome second)
        {
            if (ReferenceEquals(null, first) || ReferenceEquals(null, second))
                throw new NullReferenceException();

            double[] result = new double[first.Size + second.Size - 1];

            for (int i = 0; i < first.Size; i++)
            {
                for (int j = 0; j < second.Size; j++)
                {
                    result[i + j] += first[i] * second[i];
                }
            }

            return new Polinome(result);
        }

        /// <summary>
        /// Multiplu polinome on any number without optimization of degree polynomial
        /// </summary>
        /// <param name="number">Any Number</param>
        /// <param name="polinome">Polinime</param>
        /// <returns>The product of polynomial on number</returns>

        public static Polinome operator *(double number, Polinome polinome)
        {
            if (ReferenceEquals(null, polinome))
                throw new NullReferenceException();

            double[] result = new double[polinome.Size];

            for (int i = 0; i < polinome.Size; i++)
            {
                result[i] = number * polinome[i];
            }

            return new Polinome(result);
        }

        /// <summary>
        /// Subtraction two polinomials
        /// </summary>
        /// <param name="first">First polinome</param>
        /// <param name="second">Second polinome</param>
        /// <returns>Difference of polynomials</returns>

        public static Polinome operator -(Polinome first, Polinome second)
        {
            Polinome result = first + (-1.0) * second;
            return result;
        }

        /// <summary>
        /// Unary plus
        /// </summary>
        /// <param name="polinome">Polinome</param>
        /// <returns>Polinome after increments his members</returns>
        public static Polinome operator ++(Polinome polinome)
        {
            if (ReferenceEquals(null, polinome))
                throw new NullReferenceException();

            double[] result = new double[polinome.Size];

            for (int i = 0; i < polinome.Size; i++)
            {
                result[i]++;
            }

            return new Polinome(result);
        }

        /// <summary>
        /// Unary minus
        /// </summary>
        /// <param name="polinome">Polinome</param>
        /// <returns>Polinome after decrements his members</returns>

        public static Polinome operator --(Polinome polinome)
        {
            if (ReferenceEquals(null, polinome))
                throw new NullReferenceException();

            double[] result = new double[polinome.Size];

            for (int i = 0; i < polinome.Size; i++)
            {
                result[i]--;
            }

            return new Polinome(result);
        }

        /// <summary>
        /// The equality operator.
        /// </summary>
        /// <param name="first">First polinome</param>
        /// <param name="second">Second polinome</param>
        /// <returns>True if the values of its operands are equal, false otherwise</returns>

        public static bool operator ==(Polinome first, Polinome second)
        {
            if (ReferenceEquals(null, first) || ReferenceEquals(null, second))
                throw new ArgumentNullException();

            return ReferenceEquals(first, second) || first.Equals(second);
        }

        /// <summary>
        /// The inequality operator. 
        /// </summary>
        /// <param name="first">First polinome</param>
        /// <param name="second">Second polinome</param>
        /// <returns>False if its operands are equal, true otherwise.</returns>
        public static bool operator !=(Polinome first, Polinome second)
        {
            return !(first == second);
        }


        #region Override operators

        /// <summary>
        /// The equality operator of classes.
        /// </summary>
        /// <param name="polinome">Polinome</param>
        /// <returns>True if the values of its operands are equal, false otherwise.</returns>

        public bool Equals(Polinome polinome)
        {
            if (ReferenceEquals(null, polinome))
               throw new ArgumentNullException();

            if (Size != polinome.Size)
                return false;

            for (int i = 0; i < Size; i++)
            {
                if (CoefficientList[i] != polinome[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>String line</returns>

        public override string ToString()
        {
            var str = string.Empty;

            for (int i = CoefficientList.Length - 1; i != -1; i--)
            {
                if (CoefficientList[i] != 0)
                    str += $"{CoefficientList[i]}x^{i} ";

            }
            return str.TrimEnd(" "[0]);
        }

        /// <summary>
        /// override Equals
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns></returns>

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Polinome)obj);
        }


        /// <summary>
        /// override GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((CoefficientList?.GetHashCode() ?? 0) * 397) ^ Size;
            }
        }

        #endregion

        #endregion
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private double this[int index]
        {
            get
            {
                if (index < 0 || index > Size)
                    throw new IndexOutOfRangeException();

                return CoefficientList[index];
            }
        }
    }
}
