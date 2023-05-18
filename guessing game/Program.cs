namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretWord = "okoń";
            string guess = "";
            int guessCount = 0;
            int guesslimit = 3;
            bool outOfGuesses = false;
            while (guess != SecretWord && !outOfGuesses)
            {
                if (guessCount < guesslimit)
                {
                    Console.WriteLine("Jakie jest hasło?");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;

                }
            }
            if ( outOfGuesses ) 
            {
                Console.WriteLine("Koniec prób. Przegrałeś");
            }else 
            {
                Console.WriteLine("Brawo, ja bym Panu dał nagrodę");
            }
            Console.ReadLine();
        }
    }
}