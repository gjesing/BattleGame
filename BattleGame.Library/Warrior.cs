using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Library
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackMax { get; set; }
        public int BlockMax { get; set; }
        private readonly Random random = new Random();

        public Warrior(string name, int health, int attackMax, int blockMax)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        public int Attack() => random.Next(1, AttackMax + 1);

        public int Block(int attack) => attack < BlockMax ? random.Next(1, attack + 1) : random.Next(1, BlockMax + 1);
    }
}
