using System;

namespace guessing_number;

public class GuessNumber
{    
    private IRandomGenerator random;    
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;
    }

    //user variables
    public string? response;
    public int userValue;
    public int randomValue;


    public void Greet()
    {
        Console.WriteLine("---Bem-vindo ao Guessing Game---");
        Console.WriteLine("Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!");
    }

    public void ChooseNumber()
    {
        bool isParsed;
        int readGuess;
        do
        {
            isParsed = int.TryParse(Console.ReadLine(), out readGuess);
            if (isParsed && -100 < readGuess && readGuess< 100) userValue = readGuess;
            else Console.WriteLine("Por favor, digite um número inteiro:");
        } while (!isParsed || !(-100 < readGuess && readGuess< 100));    
    }
    
    public void RandomNumber()
    {
        randomValue = random.GetInt(-100, 100);
    }
    
    public void AnalyzePlay()
    {
        if (randomValue > userValue)
        {
            Console.WriteLine("Tente um número MAIOR");
        } else if (randomValue < userValue)
        {
            Console.WriteLine("Tente um número MENOR");
        } else
        {
            Console.WriteLine("ACERTOU!");
        }
    }
}