using System;

public class Calculadora
{
    private int resultadoSoma;
    private int resultadoMultiplicacao;
    private decimal resultadoDesconto;

    public Calculadora()
    {
        resultadoSoma = 0;
        resultadoMultiplicacao = 0;
        resultadoDesconto = 0;
    }

    public int Somar(int num1, int num2)
    {
        if (num1 < 0 || num2 < 0)
        {
            Console.WriteLine("Os números devem ser positivos.");
            return 0;
        }

        resultadoSoma = num1 + num2;
        return resultadoSoma;
    }

    public int Multiplicar(int num1, int num2)
    {
        if (num2 < 0)
        {
            Console.WriteLine("O segundo número deve ser positivo.");
            return 0;
        }

        resultadoMultiplicacao = num1 * num2;
        return resultadoMultiplicacao;
    }


    public decimal CalcularDesconto(decimal valor, decimal taxaDesconto)
    {
        resultadoDesconto = valor - (valor * (taxaDesconto / 100));
        return resultadoDesconto;
    }
}