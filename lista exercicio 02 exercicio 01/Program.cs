using System;

namespace lista_exercicio_02_exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo
por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das
vendas por ele efetuadas. Escrever um programa em C# que leia o número de carros por
ele vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro
vendido. Calcule e escreva o salário final do vendedor. */
            int salario;
            double carrovendido;
            double salariofinal;
            double qtcarro;
            Console.WriteLine("Escreva o Seu Salário");
            salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o Valor dos Carros Vendidos");
            carrovendido = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a quantidade de carro vendido");
            qtcarro = double.Parse(Console.ReadLine());
            /* levando em consideração que a comissão sobre o carro vendido seja 10%, o que é padrão para lojas */
            salariofinal = salario + (qtcarro * 0.1) + carrovendido * 0.05;
            
            Console.WriteLine("O Salário será " + salariofinal);
        }
    }
}
f

