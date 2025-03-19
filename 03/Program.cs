int n;
int i;
double m = 0;

Console.WriteLine("Digite quantos números seram lidos");
n = int.Parse(Console.ReadLine());

double[] vetor = new double[n];

for (i = 0; i < n; i++)
{
    Console.WriteLine("Digite os seus números:");
    vetor[i] = double.Parse(Console.ReadLine());
    m = vetor.Sum() / n;
}
var abaixom = vetor.Where(x => x < m).OrderBy(x => x);
Console.WriteLine($"media: {m}");
if (abaixom.Count() != 0)
{
    foreach (var menor in abaixom)
    {
        Console.WriteLine($"menor numero: {menor.ToString("F1")}");
    }
}
