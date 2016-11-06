using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Customer
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get;}
        public string ContactPhone { get; }
        public decimal Revenue { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="name">Name value</param>
        /// <param name="phone">Contact phone value</param>
        /// <param name="revenue">Revenue value</param>
        public Customer(string name, string phone, decimal revenue)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;
        }

        /// <summary>
        /// Override method
        /// </summary>
        /// <param name="format">format show classes</param>
        /// <returns>String line</returns>

        public string ToString(string format)
        {
            if (format == null)
                throw new ArgumentNullException();


            switch (format)
            {
                case "":
                    return Name;
                case "Name":
                    return Name;
                case "Phone":
                    return ContactPhone;
                case "Revenue":
                    return Revenue.ToString("F");

                case "NP":
                    return Name + " " + ContactPhone;
                case "NR":
                    return Name + " " + Revenue.ToString("F");

                case "PN":
                    return ContactPhone + " " + Name;
                case "PR":
                    return ContactPhone + " " + Revenue.ToString("F");

                case "RN":
                    return Revenue.ToString("C") + " " + Name;
                case "RP":
                    return Revenue.ToString("C") + " " + ContactPhone;

                case "NPR":
                    return Name + " " + ContactPhone + " " + Revenue.ToString("F");

                default:
                    throw new FormatException($"Bad format {format}. Atatata");
            }
        }
    }
}
