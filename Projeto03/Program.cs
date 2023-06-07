using System;

class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();

        Console.WriteLine("Bem-vindo à calculadora!");
        Console.WriteLine("Digite dois números inteiros para realizar a soma:"); int num1 = Convert.ToInt32(Console.ReadLine());

        int num2 = Convert.ToInt32(Console.ReadLine());
        int soma = calculadora.Somar(num1, num2);

        Console.WriteLine("Resultado da soma: " + soma);
        Console.WriteLine("Digite dois números (o primeiro pode ser negativo) para realizar a multiplicação:");

        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine()); int multiplicacao = calculadora.Multiplicar(num3, num4);

        Console.WriteLine("Resultado da multiplicação:" + multiplicacao);
        Console.WriteLine("Digite o valor e a taxa de desconto para calcular o valor com desconto:");

        decimal valor = Convert.ToDecimal(Console.ReadLine());
        decimal taxaDesconto = Convert.ToDecimal(Console.ReadLine());
        decimal valorDesconto = calculadora.CalcularDesconto(valor, taxaDesconto);

        Console.WriteLine("Valor com desconto: " + valorDesconto);
    }
}