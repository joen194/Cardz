using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocosSharp;

namespace CardGames
{
    class Card
    {
        public enum Suits
        {
            Diamond,
            Heart,
            Spade,
            Club
        }

        public enum Value
        {
            Two = 2, Three, Fore, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        public CCSprite myPrint { get; set; }
        public Suits mySuit { get; set; }
        public Value myValue { get; set; }
    }
}
