
Random numAleatorio = new Random();
int numAleatorioInteiro = numAleatorio.Next(1, 101);

do
{
    Console.WriteLine("Digite um número de 1 a 100");
    int numDigitado = int.Parse(Console.ReadLine()!);

    if (numDigitado < numAleatorioInteiro)
    {
        Console.WriteLine("Adicione pontos!");
    }
    else if (numDigitado > numAleatorioInteiro)
    {
        Console.WriteLine("Subtraia pontos!");
    }
    else
    {
        Console.WriteLine("Parabéns, você venceu!");
        break;
    }
} while (true);
    



