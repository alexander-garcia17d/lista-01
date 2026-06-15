using System;

Console.Write("Informe a idade do passageiro: ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write("Informe o valor normal da passagem: ");
decimal valorNormal = decimal.Parse(Console.ReadLine()!);

decimal valorAPagar;

if (idade <= 5)
{
    valorAPagar = 0m;
}
else if (idade >= 60)
{
    valorAPagar = valorNormal / 2m;
}
else
{
    valorAPagar = valorNormal;
}

Console.WriteLine($"Valor normal da passagem: R$ {valorNormal}");
Console.WriteLine($"Valor a pagar: R$ {valorAPagar}");
