using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite o número para calcular a tabuada");
            numero = int.Parse(Console.ReadLine());
            for(int i = 0; i <=10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
        }
    }
}
