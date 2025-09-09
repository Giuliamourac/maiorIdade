using System;

namespace maiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas a, b;

            a = new Pessoas();
            b = new Pessoas();

            Console.WriteLine("Digite o primeiro nome de uma pessoa.");
            a.Nome = Console.ReadLine()!;

            Console.WriteLine("Digite o sobrenome dessa pessoa.");
            a.Sobrenome = Console.ReadLine()!;

            Console.WriteLine("Digite a idade dessa pessoa.");
            a.Idade = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Digite o primeiro nome de outra pessoa.");
            b.Nome = Console.ReadLine()!;

            Console.WriteLine("Digite o sobrenome dessa pessoa.");
            b.Sobrenome = Console.ReadLine()!;

            Console.WriteLine("Digite a idade dessa pessoa.");
            b.Idade = Convert.ToInt32(Console.ReadLine()!);

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }
        }
    }
}