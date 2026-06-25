using LISTA;
using System.Collections.Generic;
using System.Xml.Linq;
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o id");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome");
                String name = Console.ReadLine();

                Console.WriteLine("Digite o salario");
                double salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee { Id = id, Name = name, Salary = salary};
                list.Add(employee);
            }

            Console.WriteLine("Vamos dar um bonus para um funcionário!");
            Console.WriteLine("Digite o id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario");
            double salary = double.Parse(Console.ReadLine());

          Employee em =  list.Find(x => x.Id == id);

            if (em != null) 
            {
                Console.WriteLine("Digite a porcentagem exemplo: 50% digite 50");
                double number = double.Parse(Console.ReadLine());
                em.increaseSalaray(number);
            }
            foreach (Employee employee in list) 
            {
                Console.WriteLine(employee);
            }
        }
    }
}

