using System;

Console.Write("Informe o saldo inicial: ");
decimal saldo = decimal.Parse(Console.ReadLine()!);

while (true)
{
    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Entrada de dinheiro");
    Console.WriteLine("2 - Saída de dinheiro");
    Console.WriteLine("3 - Encerrar");
    Console.Write("Opção: ");
    int operacao = int.Parse(Console.ReadLine()!);

    if (operacao == 1)
    {
        Console.Write("Informe o valor da movimentação: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);
        saldo += valor;
        Console.WriteLine($"Entrada registrada. Saldo atual: R$ {saldo}");
    }
    else if (operacao == 2)
    {
        Console.Write("Informe o valor da movimentação: ");
        decimal valor = decimal.Parse(Console.ReadLine()!);

        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saída registrada. Saldo atual: R$ {saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
    else if (operacao == 3)
    {
        Console.WriteLine($"Saldo final: R$ {saldo}");
        break;
    }
    else
    {
        Console.WriteLine("Operação inválida. Tente novamente.");
    }
}

