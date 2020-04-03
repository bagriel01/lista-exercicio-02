using System;

namespace lista_2_exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elabore um programa em C# que calcular x^n
, supondo x um número qualquer e n inteiro
não negativo. Considerar não disponível a função de potenciação*/
            double equis;
            double en;
            double result;
            Console.WriteLine("Digite um numero qualquer para passar por exponenciação");
            equis = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a potência do numero anterior.");
            en = double.Parse(Console.ReadLine());

         result=  Math.Pow(equis, en);
        }
    }
}
