using System;

Console.Write("Informe a quantidade de clientes atendidos: ");
int quantidade = int.Parse(Console.ReadLine()!);

int tempoTotal = 0;

for (int i = 0; i < quantidade; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    int tempo = int.Parse(Console.ReadLine()!);
    tempoTotal += tempo;
}

decimal tempoMedio = quantidade > 0 ? (decimal)tempoTotal / quantidade : 0m;

Console.WriteLine($"Tempo total de atendimento: {tempoTotal} minutos");
Console.WriteLine($"Tempo médio por cliente: {tempoMedio} minutos");
