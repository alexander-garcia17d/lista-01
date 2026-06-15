using System;

int nota;

while (true)
{
    Console.Write("Informe uma nota de 0 a 10: ");
    nota = int.Parse(Console.ReadLine()!);

    if (nota >= 0 && nota <= 10)
    {
        Console.WriteLine($"Nota registrada: {nota}");
        break;
    }

    Console.WriteLine("Nota inválida. Informe novamente.");
}
