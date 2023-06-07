using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            
            Produto p = new Produto(nome, preco);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Digite o n de produtos: ");
            int qnt = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qnt);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o número de produtos a ser removidos: ");
            qnt = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qnt);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}