using System;

Console.Write("Informe o número da tabuada: ");
int numero = int.Parse(Console.ReadLine()!);

for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    int resultado = numero * multiplicador;
    Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
}

