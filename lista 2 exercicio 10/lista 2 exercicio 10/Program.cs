using System;

namespace lista_2_exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Elabore um programa que leia uma idade da pessoa em dias e retorne na tela a
quantidade de anos, meses e dias que ela possui no seguinte formato:
“ x ano(s), y mês(es), z dia(s)”
Onde x, y e z são os valores das quantidades de anos, meses e dias .*/
            int diavivo;
            int x;
            int y;
            int z;
            int final;
            Console.WriteLine("Hello World! Digite quantos dias você está vivo.");
            diavivo = int.Parse(Console.ReadLine());

            x = (diavivo / 365);
            y = (x * 12);
            z = diavivo;

            Console.WriteLine("Você está vivo há " + x + " Anos " + y + " Meses e " + z + " Dias.");
            
        }
    }
}
