using System;
namespace Course
{
    class For
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros vão ser somados?");
            int times = int.Parse(Console.ReadLine());
            int add = 0;

            for (int count = 1; times >= count; count++)
            {
               Console.Write($"Valor #{count}:");
               int teste = int.Parse(Console.ReadLine());
               add += teste;
            }
            Console.Write($"Resultado da soma dos valores:{add}");
        }
    }
}