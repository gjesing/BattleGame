using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Library
{
    public class Battle
    {
        public Warrior Warrior1 { get; set; }
        public Warrior Warrior2 { get; set; }
        private int round = 0;

        public Battle(Warrior warrior1, Warrior warrior2)
        {
            Warrior1 = warrior1;
            Warrior2 = warrior2;
        }

        public void StartFight()
        {
            while (Warrior1.Health > 0 && Warrior2.Health > 0)
            {
                round++;
                if (round % 2 == 1)
                    GetAttackResult(Warrior1, Warrior2);
                else
                    GetAttackResult(Warrior2, Warrior1);
            }
            Console.WriteLine("\nGame over");
            Console.ReadLine();
        }

        public void GetAttackResult(Warrior attacker, Warrior blocker)
        {
            int attack = attacker.Attack();
            int damage = attack - blocker.Block(attack);
            blocker.Health -= damage;
            if (blocker.Health <= 0)
                blocker.Health = 0;
            Console.WriteLine($"\n{attacker.Name} attacks {blocker.Name} and deals {damage} damage.\n{blocker.Name} has {blocker.Health} health");
            if (blocker.Health == 0)
                Console.WriteLine($"\n{blocker.Name} has died and {attacker.Name} is victorious");
        }

    }
}
