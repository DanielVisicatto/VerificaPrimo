Console.Write("Digite o número a verificar: ");
if (!double.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Por favor digite um número válido!");
}
else
{
    bool primeNumber = true;

    for(int i = 2; i < number; i++) // dividir o numero de 2 a ele -1 se true nao é primo.
    {
        if(number % i == 0)
        {
            primeNumber = false;
            break;
        }
    }

    if (primeNumber && number > 0)
        Console.WriteLine("Primo!");
    else
        Console.WriteLine("Não Primo!");
}
//