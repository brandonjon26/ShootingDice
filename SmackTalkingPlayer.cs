using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "Y'all might as well just accept that I'm going to win, losers.";

        public override void Play(Player other)
        {
            Console.WriteLine(Taunt);
        }
    }
}