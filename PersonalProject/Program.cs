using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheProject();

            //Why this project? Do you like games, want to make an app for cooking, want to make the next tik tok. This tells us who you are:
            //I enjoy playing games, I grew up with gamers but I am not an all time gamer woman but I really enjoy games that does not require lot of skills (i.e: Uno, Card Game Speed, Yahtzee, etc ). During it's peak, I did try out Fortnite and that was a mission itself. Still cannnot understand how one can build and edit so fast. My eyes are not as fast registering what is happening as it does for other gamers. 

            // What you wanted to learn from this project? Did you want to know what goes into making a character move.Or how to calculate recipe values, or how to use an app to do calculations for your D and D game.Focused learning pays dividends. 
            //This project was more for fun, Implementing techniques I've learned thus far and joining them into a program. Although, I could of done so much better than what was produced. I knew when I initiated this, I wanted a loop , the if statements and 
            // a trace of scoring. I still have my weakness on how to structure an if but with more practice I am starting to understand the concept and how it works. 

            //What you ended up learning from this project ? You will always come out learning more than you expected.What breaks, what hurdles, what was surpisingly easy.You'll find, doing this, that you probably learned a lot more then you expected. And interviewers will ask you about this stuff specifically. // When I structure my project, I learned that placement is very important when it comes to coding. When producing the score and announcing the winner I had the if statement right in the same area brackets as my for loop, then learned it's suppose to be outside of that. I'm still learning as I go but this practice was great exercise for me. 
        }
        public static void TheProject()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Winter Number Scrimmage");   //TITLE OF THE GAME 
            Console.WriteLine("-----------------------");

            //Like the old days , there was this game called number muncher, usually based on equation but my goal is to go against an
            //Winterbot and win by chance. 

            int numberChance; //The game is mainly working with randomize number 
            Random random = new Random();

            int theBot; // The number that the bot produces 

            int yourScore = 0; // Player scores - to keep track of scoring 
            int winterScore = 0; // Bot scores -  to keep track of scoring 

            Console.WriteLine("Please enter your player name: "); // asking for player's name 
            string playerName = Console.ReadLine();

            Console.WriteLine($"Great! {playerName}, you go first");

            for(int i = 0; i < 12; i++) //I used a for loop , therefore we can go against the bot 12(favorite number) times in a single round.
            {
                Console.WriteLine("Press enter to display a number:  "); //This question will be asked 12 times 
                Console.ReadKey();
                
                numberChance = random.Next(1, 101); //Random numbers between 1 - 100  //Player Random Number 
                Console.WriteLine($"{playerName} you got: {numberChance} snowflakes");

                Console.WriteLine("******"); // For easy viewing , sectioning w/ a line of stars 

                theBot = random.Next(1, 101);
                Console.WriteLine($"Winterbot got {theBot} snowflakes"); //Winterbot Random Number 
                Console.WriteLine();

                if (numberChance > theBot) // Player score is higher than WinterBot score 
                {
                    yourScore++; // Points increase by 1 
                    Console.WriteLine($"{playerName} captured the most."); // Since player score higher , this will display 
                }
                else if (numberChance < theBot)//Winterbot scores higher than player 
                {
                    winterScore++; //Points increase by 1 for Winterbot 
                    Console.WriteLine("Winterbot captured the most"); 
                }
                else
                {
                    Console.WriteLine("It's A Tie!"); // if none of the above condition runs , this will run. 
                }
                Console.ReadKey();
            }
            if (yourScore > winterScore)// Player scores higher than bot , player wins 
            {
                Console.WriteLine($"{playerName} is the WINNER");
            }
            else if (yourScore < winterScore)// Winterbot scores higher than player , Winterbot Wins 
            {
                Console.WriteLine("Winterbot is the WINNER");
            }
            else
            {
                Console.WriteLine("Great Job! It's a TIE");// It's a draw if the score is even 
            }
            
        }
    }
}
