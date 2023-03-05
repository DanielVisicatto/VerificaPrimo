Console.Write("Digite o número a verificar: ");
if (!double.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Por favor digite um número válido!");
}
else
{
    bool ehPrimo = VerificaPrimo(number); // Passando number como parâmetro para VerificaPrimo()
    RetornoUsuario(ehPrimo); // Passando isPrime como parâmetro para RetornoUsuario()
}

bool VerificaPrimo(double number) // Recebendo o número a ser verificado como parâmetro
{
    bool primeNumber = true;
    for (int i = 2; i < number; i++) // dividir o numero de 2 a ele -1 se true nao é primo.
    {
        if (number % i == 0)
        {
            primeNumber = false;
            break;
        }
    }
    return primeNumber;
}

void RetornoUsuario(bool primeNumber)
{
    if (primeNumber)
        Console.WriteLine("Primo!");
    else
        Console.WriteLine("Não Primo!");
}