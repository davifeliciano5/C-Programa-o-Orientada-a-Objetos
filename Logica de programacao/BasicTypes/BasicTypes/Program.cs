using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool fristType = false;
            char gender = 'F';
            char letter = '\u0041';
            byte number1 = 126;
            int secondType = 100;
            long thirdType = 123123L;
            float fourthType = 3.1F;
            double fifthType = 3.1;
            String name = "Davi";
            Object name2 = "Feliciano";
            Decimal maxDecimal = Decimal.MaxValue;

            Console.WriteLine(fristType);
            Console.WriteLine(gender);
            Console.WriteLine(letter);
            Console.WriteLine(number1);
            Console.WriteLine(secondType);
            Console.WriteLine(thirdType);
            Console.WriteLine(fourthType);
            Console.WriteLine(fifthType);
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(maxDecimal);


            String product1 = "Computador";
            String product2 = "Mesa para escritório";

            byte age = 21;
            int code = 5290;
            char gender1 = 'M';

            double price = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo o preço é ${1}",product1, price);
            Console.WriteLine("{0}, cujo o preço é ${1}", product2, price2);

            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", age, code, gender1);

            Console.WriteLine("A medida com oito casas decimais: {0:F8}", measure);
            Console.WriteLine("Arredondando para (três casas decimais): {0:F3}", measure);
            Console.WriteLine("Separando decimal invariant culture: " + measure.ToString("F3",CultureInfo.InvariantCulture));


            int a = 5;
            int b = 2;

            //double divisionCasting = (double)a / b;
            //Console.WriteLine(divisionCasting);

            //Console.WriteLine("Enter you full name: ");
            //String name3 = Console.ReadLine();

            //Console.WriteLine("How many bedrooms do you have in your house: ");
            //int qtdHouse = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter with price of product: ");
            //float priceProduct = float.Parse(Console.ReadLine());

            //Console.WriteLine(name3 + " " + qtdHouse +" " + priceProduct);

            //Console.WriteLine("Sum:");
            //int number3 = int.Parse(Console.ReadLine());
            //int number4 = int.Parse(Console.ReadLine());
            //Console.WriteLine(number3 + number4);

            //float ray = float.Parse(Console.ReadLine());
            //float result = 3.14159F * (ray * ray);
            //Console.WriteLine(result);

            //float[] ListNumber = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();

            //float result = ((ListNumber[0] * ListNumber[1]) - (ListNumber[2] * ListNumber[3]));

            float numberF = float.Parse(Console.ReadLine());
            float timeWork = float.Parse(Console.ReadLine());
            float timePrice = float.Parse(Console.ReadLine());
            Console.WriteLine(numberF);
            float result = timePrice * timeWork;
            Console.WriteLine("{0:2F}",result);




        }
    }
}