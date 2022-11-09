using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsterkampf_Simulator
{
    internal class Goblin : Monster
    {
        
        int AP = 100;
        int DP = 200;
        int S = 2000;


        public void attackEnemy()
        {




        }
        public override void Die()
        {

            Console.WriteLine("This Goblin died");


        }
    }
}
