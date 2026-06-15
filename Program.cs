using System;

Console.Write("Informe a idade: ");
int idade = int.Parse(Console.ReadLine()!);

if (idade >= 0 && idade <= 11)
{
    Console.WriteLine("Faixa etária: criança.");
}
else if (idade >= 12 && idade <= 17)
{
    Console.WriteLine("Faixa etária: adolescente.");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Faixa etária: adulto.");
}
else if (idade >= 60)
{
    Console.WriteLine("Faixa etária: idoso.");
}

