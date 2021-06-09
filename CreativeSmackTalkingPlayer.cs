using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts { get; } = new List<string>()
        {
            "Some may call this arrogance, I say it's pride in the absolute unit I am.",
            "Aye buddy, you do all that talkin and you're STILL at the bottom of the leader board.",
            "It's not easy being this good.",
            "Name the time or place, I'll still beat you.",
            "He he... I just do the job.",
            "It must suck being that ass at this.",
            "It gets lonely here at the top. Give me a challenge, would ya?",
            "Aye guy, how bout ya move yaself to the back of the line, capisce?",
            "You want some more?"
        };
        public override void Play(Player other)
        {
            int x = new Random().Next(9) + 1;
            Console.WriteLine(Taunts[x]);
        }
    }
}