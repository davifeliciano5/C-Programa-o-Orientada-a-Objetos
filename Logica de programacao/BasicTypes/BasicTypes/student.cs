using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTypes
{
    internal class student
    {
        public String nome;
        public double[] grade;

        public String Aprove()
        {
            double gradeGeneral = 0;
            double average = 0;
            if (grade == null || grade.Length == 0||grade.Length > 3) return "Erro";

            average = grade.Average();

            return average >= 60 ? "Aprovado" : "Reprovado";
           
        }
    }
}
