using System;

Console.Write("Informe a primeira pontuação: ");
int primeira = int.Parse(Console.ReadLine());

Console.Write("Informe a segunda pontuação: ");
int segunda = int.Parse(Console.ReadLine());

Console.Write("Informe a terceira pontuação: ");
int terceira = int.Parse(Console.ReadLine());

if (primeira == segunda && segunda == terceira)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else
{
    int maior = primeira;
    if (segunda > maior)
    {
        maior = segunda;
    }
    if (terceira > maior)
    {
        maior = terceira;
    }

    Console.WriteLine($"Maior pontuação: {maior}");
}

