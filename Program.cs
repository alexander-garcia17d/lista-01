using System;

Console.Write("Informe a quantidade inicial em estoque: ");
int estoque = int.Parse(Console.ReadLine()!);

while (true)
{
    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Entrada de produtos");
    Console.WriteLine("2 - Saída de produtos");
    Console.WriteLine("3 - Consultar estoque");
    Console.WriteLine("4 - Encerrar");
    Console.Write("Opção: ");
    int operacao = int.Parse(Console.ReadLine()!);

    if (operacao == 1)
    {
        Console.Write("Informe a quantidade movimentada: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        estoque += quantidade;
        Console.WriteLine($"Entrada registrada. Estoque atual: {estoque}");
    }
    else if (operacao == 2)
    {
        Console.Write("Informe a quantidade movimentada: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        if (quantidade <= estoque)
        {
            estoque -= quantidade;
            Console.WriteLine($"Saída registrada. Estoque atual: {estoque}");
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }
    else if (operacao == 3)
    {
        Console.WriteLine($"Estoque atual: {estoque}");
    }
    else if (operacao == 4)
    {
        Console.WriteLine($"Estoque final: {estoque}");
        break;
    }
    else
    {
        Console.WriteLine("Operação inválida. Tente novamente.");
    }
}


