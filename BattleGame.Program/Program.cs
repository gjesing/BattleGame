using BattleGame.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior1 = new Warrior("", 200, 120, 40);
            while (string.IsNullOrWhiteSpace(warrior1.Name))
            {
                Console.WriteLine("Enter name of warrior 1:");
                warrior1.Name = Console.ReadLine();
            }
            Warrior warrior2 = new Warrior("", 200, 120, 40);
            while (string.IsNullOrWhiteSpace(warrior2.Name))
            {
                Console.WriteLine("Enter name of warrior 2:");
                warrior2.Name = Console.ReadLine();
            }
            new Battle(warrior1, warrior2).StartFight();
        }
    }
}
