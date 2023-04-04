namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dados do parafuso A
            Console.WriteLine("Parafuso A");
            Console.Write("Digite o código: ");
            string codigoA = Console.ReadLine();
            Console.Write("Digite a quantidade de peças: ");
            int quantidadeA = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário: ");
            double valorUnitarioA = double.Parse(Console.ReadLine());

            // Dados do parafuso B
            Console.WriteLine("Parafuso B");
            Console.Write("Digite o código: ");
            string codigoB = Console.ReadLine();
            Console.Write("Digite a quantidade de peças: ");
            int quantidadeB = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário: ");
            double valorUnitarioB = double.Parse(Console.ReadLine());

            // Porcentagem de IPI a ser acrescentada
            Console.Write("Digite a porcentagem de IPI a ser acrescentada: ");
            double ipi = double.Parse(Console.ReadLine());

            // Cálculo do valor total dos parafusos A e B com IPI
            double valorTotalA = quantidadeA * valorUnitarioA * (1 + ipi / 100);
            double valorTotalB = quantidadeB * valorUnitarioB * (1 + ipi / 100);

            // Exibição dos resultados
            Console.WriteLine("Valor total do parafuso A com IPI: R$ {0:0.00}", valorTotalA);
            Console.WriteLine("Valor total do parafuso B com IPI: R$ {0:0.00}", valorTotalB);

            Console.ReadKey();
        }
    }
}