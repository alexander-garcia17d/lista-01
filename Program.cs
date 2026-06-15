using System;

Console.Write("Informe o primeiro valor: ");
decimal valor1 = decimal.Parse(Console.ReadLine()!);

Console.Write("Informe o segundo valor: ");
decimal valor2 = decimal.Parse(Console.ReadLine()!);

Console.Write("Informe o terceiro valor: ");
decimal valor3 = decimal.Parse(Console.ReadLine()!);

Console.Write("Informe o quarto valor: ");
decimal valor4 = decimal.Parse(Console.ReadLine()!);

Console.Write("Informe o quinto valor: ");
decimal valor5 = decimal.Parse(Console.ReadLine()!);

decimal soma = valor1 + valor2 + valor3 + valor4 + valor5;
decimal media = soma / 5m;

Console.WriteLine($"Soma dos valores: {soma}");
Console.WriteLine($"Média dos valores: {media}");
