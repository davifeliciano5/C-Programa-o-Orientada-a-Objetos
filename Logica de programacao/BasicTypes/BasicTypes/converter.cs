using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTypes
{
    internal class converter
    {
        static double tax = 0.06;
        public static double amount;
        public static double price;

        public static double Cotacao()
        {
            return amount * price * tax;
        }
    }
}
