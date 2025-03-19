int n;
int i;
string[] sexoaltura;
double altura;
string sexo;
double menorAltura = 3;
double maiorAltura = 0;
double mediaMulher = 0;
double quntdHomem = 0;
double quntdMulher = 0;
double somaAlturaMulher = 0;

Console.WriteLine("Digite quantas vezes será lido:");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("Digite a altura e o sexo (m ou f):");
    sexoaltura = Console.ReadLine().Split();
    altura = double.Parse(sexoaltura[0]);
    sexo = (sexoaltura[1]);

    if (altura <= menorAltura)
    {
        menorAltura = altura;
    }
    if (altura >= maiorAltura)
    {
        maiorAltura = altura;
    }
    if (sexo == "m")
    {
        quntdHomem++;
    }
    else
    {
        quntdMulher++;
        somaAlturaMulher += altura;
    }
    if (sexo == "f")
    {
        mediaMulher = somaAlturaMulher / quntdMulher;
    }
}
Console.WriteLine($"menor altura: {(menorAltura):F2}");
Console.WriteLine($"maior altura: {(maiorAltura):F2}");
Console.WriteLine($"media da mulher: {(mediaMulher):F2}");
Console.WriteLine($"numero de homens: {quntdHomem}");