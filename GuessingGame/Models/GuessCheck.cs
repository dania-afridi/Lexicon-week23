using Microsoft.AspNetCore.Mvc;

namespace GuessingGame.Models
{
    public class GuessCheck
    {
        public static string Guess(int? userGuess)
        {
            if (!userGuess.HasValue)
            {
                return "Please! provide a valid guess.";
                
            }
            int secreteNumber = GenerateRandomNumber();
            //int storedNumber = (int)Session[sessionKey];
            //int guessCount = (int)Session[sessionCount] + 1;

            if (userGuess == secreteNumber)
            {
                //int secreteNumber = GenerateRandomNumber();
                //Session[sessionKey] = secreteNumber;
                //Session[sessionCount] = 0;

                 return "Congragulations! your guess is correct.";
            }
            else if (userGuess < secreteNumber)
            {
                return "Your guess is too low. Try a higher number.";
            }
            else
            {
                return "Your guess is too high. Try a lower number.";
            }

            //ViewBag.GuessCount = guessCount;
            
        }
        private static int GenerateRandomNumber()
        {
            return new Random().Next(1, 101);
        }
    }
}
