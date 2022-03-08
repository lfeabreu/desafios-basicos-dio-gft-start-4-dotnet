using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            List<string> listaProdutos = new List<string>();
            string lista;
            List<string> listaLimpa;
            string listaFinal;
            for( int i = 1 ; i <= totalDeCasosDeTeste ; i++ )
            {
                lista = Console.ReadLine();
                listaProdutos.Add(lista);

            }
            for( int i = 0 ; i < listaProdutos.Count() ; i++ )
            {
                listaLimpa = new List<string>(new List<string>(listaProdutos.ElementAt(i).Split()).Distinct());
                listaLimpa.Sort();
                listaFinal = listaLimpa.ElementAt(0);
                for( int j = 1 ; j < listaLimpa.Count() ; j++ )
                {
                    listaFinal += " " + listaLimpa.ElementAt(j); 
                }
                Console.WriteLine(listaFinal);
            }
        }
    }
}
