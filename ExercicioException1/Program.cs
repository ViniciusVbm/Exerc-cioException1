namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        int contador = 0;
        int conta = 0;
        float media = 0;

        try
        {
            Console.WriteLine("Digite quantos números serão somados: ");
            contador = int.Parse(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 100)
                {
                    throw new Excecao("Número não pode ser maior que 100.");
                }
                conta += numero;
            }
            if (contador > 0)
            {
                media = (float)conta / contador;
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro de Formatação: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Soma total: {conta}");
            Console.WriteLine($"Quantidade de números inseridos: {contador}");
            Console.WriteLine($"Média Total: {media:F2}");
        }
    }
}