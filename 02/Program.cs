int n;
int i;
int a;
int b;
int c = 0;


Console.WriteLine("Digite quantas repetições");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("Digite o valor de a");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de b");
    b = int.Parse(Console.ReadLine());
    c = a + b;
    Console.WriteLine("soma de a+b:");
    Console.WriteLine(c);
}