using Arrays;
using System.IO.Pipelines;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite a quantidade de quartos: ");
            int n = int.Parse(Console.ReadLine());

            Room[] r = new Room[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o seu nome: ");
                String nome = Console.ReadLine();

                Console.WriteLine("Digite o seu Email: ");
                String email = Console.ReadLine();

                Console.WriteLine("Digite o numero do quarto 0 a 9: ");
                int numeroDoquarto = int.Parse(Console.ReadLine());

                r[i] = new Room { Name = nome, Email =email, NumRoom = numeroDoquarto };
            }

            for (int i = 0; i <= r.Length; i++) 
            {
                Console.WriteLine(r[i]);
            }
        }
    }
}