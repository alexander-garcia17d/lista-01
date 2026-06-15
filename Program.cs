using System;

int senha;

while (true)
{
    Console.Write("Informe a senha: ");
    senha = int.Parse(Console.ReadLine()!);

    if (senha == 1234)
    {
        Console.WriteLine("Acesso permitido.");
        break;
    }

    Console.WriteLine("Senha incorreta. Tente novamente.");
}
