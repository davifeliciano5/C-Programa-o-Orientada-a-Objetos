using EncapsulamentoBanco;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero da conta: ");
            double accountNumer = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular conta: ");
            String holderName = Console.ReadLine();

            Console.WriteLine("Deseja deseja realizar um deposito inical 1-sim 0-não");
            int wantToType =int.Parse(Console.ReadLine());

            Conta c = new(accountNumer, holderName);

            if (wantToType == 1)
            {
            Console.WriteLine("Digite o  valor: ");
            double amount = double.Parse(Console.ReadLine());
                c.deposit(amount);
            }


            int loopVariable=100;

            while (loopVariable != 0)
            {

                Console.WriteLine("Realizar saque 1");
                Console.WriteLine("Realizar deposito 2");
                Console.WriteLine("Trocar nome 3");
                Console.WriteLine("Ver informações da conta 4");
                Console.WriteLine("0 para sair");

                loopVariable = int.Parse(Console.ReadLine());
                if (loopVariable == 1)
                {
                    Console.WriteLine("Digite o  valor: ");
                    double amount = double.Parse(Console.ReadLine());
                    c.sake(amount);
                }
                else if (loopVariable == 2)
                {
                    Console.WriteLine("Digite o  valor: ");
                    double amount = double.Parse(Console.ReadLine());
                    c.deposit(amount);

                }
                else if (loopVariable == 3)
                {
                    Console.WriteLine("Digite o nome do titular conta: ");
                    String holder = Console.ReadLine();
                    c.SetHolderName(holder);
                }
                else if (loopVariable == 4)
                {
                    Console.WriteLine(c);
                }
            }

        }
    }
}
