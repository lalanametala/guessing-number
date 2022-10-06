namespace guessing_number;

public class Program
{    
    public static void Main()
    {
        GuessNumber Game = new();
        Game.Greet();        
        Game.RandomNumber();
        do
        {
            Game.ChooseNumber();
            Game.AnalyzePlay();
        }while(Game.randomValue != Game.userValue);         
    }   
}
