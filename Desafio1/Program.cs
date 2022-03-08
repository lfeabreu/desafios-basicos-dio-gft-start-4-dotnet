using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quociente, resto;
            int[] nota = {100, 50, 20, 10, 5, 2, 1};

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            
            resto = n;
            
            for( int i = 0 ; i < nota.GetLength(0) ; i++ )
            {
                quociente = resto / nota[i];
                Console.WriteLine($"{quociente} nota(s) de R$ {nota[i]},00");
                resto = resto % nota[i];
            }
        }
    }
}
