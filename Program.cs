using System;

namespace ultimaparcela
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal;
            double parcelas;
            double result;

            DateTime dataAtual = DateTime.Now;
            DateTime parcelaFinal;

            Console.Write("Digite o valor Total: ");
            valorTotal = double.Parse(Console.ReadLine() );
            
            Console.Write("Digite o valor de Parcelas: ");
            parcelas = double.Parse(Console.ReadLine());
            Console.Write("\n");

            result = valorTotal / parcelas;

            parcelaFinal = dataAtual.AddMonths(8);
            Console.WriteLine($"Sua ultima parcela será em: {parcelaFinal},no valor de R${result}");
        }
    }
}