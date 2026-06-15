using System;

Console.Write("Informe o primeiro número: ");
int primeiro = int.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
int segundo = int.Parse(Console.ReadLine());

if (primeiro > segundo)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (segundo > primeiro)
{
    Console.WriteLine("O segundo número é maior.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}
