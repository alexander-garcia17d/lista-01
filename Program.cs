using System;

Console.Write("Informe o número inicial da contagem regressiva: ");
int inicio = int.Parse(Console.ReadLine()!);

for (int i = inicio; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("Fim da contagem.");
