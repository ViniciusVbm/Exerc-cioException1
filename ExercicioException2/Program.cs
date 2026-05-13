using System;

int[] vetor = new int[10];
int valores = 0;

Console.WriteLine("Valores de um vetor\n");
Console.WriteLine("Digite posição fora de 0 a 9 ou letras para testar as exceções.\n");

while (valores < 10)
{
    try
    {
        Console.Write($"Faltam {10 - valores} valores. Informe a posição do vetor: ");
        int posicao = int.Parse(Console.ReadLine()!);

        Console.Write($"Valor inteiro a ser inserido na posição {posicao}: ");
        int valor = int.Parse(Console.ReadLine()!);

        vetor[posicao] = valor;

        Console.WriteLine($"Valor {valor} armazenado na posição {posicao}.\n");

        valores++;
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Erro: posição inexistente. O vetor possui posições de 0 até 9.\n");
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: digite apenas números inteiros.\n");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}\n");
    }
}

Console.WriteLine("\nVetor preenchido:\n");

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Posição [{i}] = {vetor[i]}");
}