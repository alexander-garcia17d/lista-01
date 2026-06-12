Console.Write("Informe o valor total da compra: ");
double valorTotal = double.Parse(Console.ReadLine());

double desconto = 0;
if (valorTotal >= 200)
{
    desconto = valorTotal * 0.10;
}

double valorFinal = valorTotal - desconto;

Console.WriteLine($"Valor original: R$ {valorTotal:F2}");
Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");