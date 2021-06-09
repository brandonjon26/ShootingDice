using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override void Play(Player other)
        {
            Console.WriteLine("Your turn! Select a roll between 1 and 6.");
            int yourRoll = Int32.Parse(Console.ReadLine());
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolled {yourRoll}");
            Console.WriteLine($"{other.Name} rolled {otherRoll}");

            if (yourRoll > otherRoll)
            {
                Console.WriteLine($"{Name} is the winner!");
            }
            else if (yourRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} is the winner!");
            }
            else
            {
                Console.WriteLine("It's a tie... No one likes a tie.");
            }
        }
    }
}