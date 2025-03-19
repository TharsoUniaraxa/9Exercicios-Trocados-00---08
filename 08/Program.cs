int n;
int i;
string[] compravenda;
string produto;
double compra;
double venda;
double lucro;
double percentualLucro;
double LucroAbaixo = 0;
double LucroEntre = 0;
double LucroAcima = 0;
double ValorTotalCompra = 0;
double ValorTotalVenda = 0;
double LucroTotal = 0;

Console.WriteLine("Digite quantas vezes será lido:");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("Digite o nome da compra, o valor de compra o valor de venda:");
    compravenda = Console.ReadLine().Split();
    produto = compravenda[0];
    compra = double.Parse(compravenda[1]);
    venda = double.Parse(compravenda[2]);

    lucro = venda - compra;
    percentualLucro = (lucro / compra) * 100;

    ValorTotalCompra += compra;
    ValorTotalVenda += venda;
    LucroTotal += lucro;

    if (percentualLucro < 10)
    {
        LucroAbaixo++;
    }
    else if (percentualLucro >= 10 && percentualLucro <= 20)
    {
        LucroEntre++;
    }
    else
    {
        LucroAcima++;
    }
}
Console.WriteLine($"lucro abaixo de 10%: {LucroAbaixo}");
Console.WriteLine($"lucro entre 10% e 20%: {LucroEntre}");
Console.WriteLine($"lucro acima 20%: {LucroAcima}");
Console.WriteLine($"valor total de compra: {(ValorTotalCompra):F2}");
Console.WriteLine($"valor total de Venda: {(ValorTotalVenda):F2}");
Console.WriteLine($"lucro total: {(LucroTotal):F2}");