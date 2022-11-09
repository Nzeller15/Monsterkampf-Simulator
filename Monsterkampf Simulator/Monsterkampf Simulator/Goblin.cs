using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsterkampf_Simulator
{
    internal class Goblin : Monster
    {
        int HP = 0;
        int AP = 0;
        int DP = 0;
        int S = 0;


        public void attackEnemy()
        {




        }
        public override void Die()
        {

            Console.WriteLine("This Goblin died");


        }
    }
}
