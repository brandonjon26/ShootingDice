using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int lowRoll = other.Roll();
            int highRoll = lowRoll + 1;

            Console.WriteLine($"{Name} rolls a {highRoll}");
            Console.WriteLine($"{other.Name} rolls a {lowRoll}");
        }
    }
}
