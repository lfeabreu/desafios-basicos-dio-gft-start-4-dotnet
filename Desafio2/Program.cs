using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            
            if(tresLadosFormamUmTriangulo(a,b,c))
            {
                double perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1")}");
            }else{
                double area = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {area.ToString("F1")}");
            }
        }

        static bool tresLadosFormamUmTriangulo(double a, double b, double c)
        {
            double maiorLado, somaOutrosLados;
            if( a > b ){
                if( a > c ){
                    maiorLado = a;
                    somaOutrosLados = b + c;
                }else{
                    maiorLado = c;
                    somaOutrosLados = a + b;
                }
            }else{
                if( b > c ){
                    maiorLado = b;
                    somaOutrosLados = a + c;
                }else{
                    maiorLado = c;
                    somaOutrosLados = a + b;
                }
            }
            return somaOutrosLados > maiorLado ? true : false;
        }
    }
}
