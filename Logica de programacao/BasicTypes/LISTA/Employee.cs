using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LISTA
{
    internal class Employee
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


       public void increaseSalaray( double pecentage)
        {
            pecentage = pecentage  /  100;
            double value = Salary * pecentage;
            Salary += value;
        }

        public override string ToString()
        {
            return "id: "  + Id + " Nome: " + Name + " Salario: " + Salary;
        }
    }
}
