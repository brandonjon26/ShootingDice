using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int lowRoll = other.Roll();
            int highRoll = lowRoll + 1;

            Console.WriteLine($"{Name} rolls a {highRoll}");
            Console.WriteLine($"{other.Name} rolls a {lowRoll}");

            if (highRoll > lowRoll)
            {
                Console.WriteLine($"{Name} is the winner!");
            }
            else
            {
                throw new Exception("You aren't worth my damn time.");
            }
        }
    }
}