using System;

namespace lista_exercicio_02_exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa em C# que leia uma temperatura em graus Celsius e apresente-a
convertida em graus Fahrenheit. A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F
é a temperatura em Fahrenheit e C é a temperatura em Celsius. */

            int fahrenheit;
            int celsius;

            Console.WriteLine("Escreva a Temperatura em Celsius");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine("A Temperatura em Fahrenheit vai ser " + fahrenheit);

        }
    }
}
