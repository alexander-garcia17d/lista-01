using System;

Console.Write("Informe o número final da contagem: ");
int limite = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= limite; i++)
{
    Console.WriteLine(i);
}
