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
            Console.WriteLine("Enter name of warrior 1:");
            Warrior warrior1 = new Warrior(Console.ReadLine(), 200, 120, 40);
            Console.WriteLine("Enter name of warrior 2:");
            Warrior warrior2 = new Warrior(Console.ReadLine(), 200, 120, 40);
            new Battle(warrior1, warrior2).StartFight();
        }
    }
}
