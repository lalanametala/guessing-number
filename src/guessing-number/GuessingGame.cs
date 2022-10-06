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
        throw new NotImplementedException();
    }

    public void ChooseNumber()
    {
        throw new NotImplementedException();     
    }
    
    public void RandomNumber()
    {
        throw new NotImplementedException();
    }
    
    public void AnalyzePlay()
    {
        throw new NotImplementedException();
    }
}