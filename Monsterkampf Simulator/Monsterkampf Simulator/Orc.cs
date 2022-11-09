using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monsterkampf_Simulator
{
    internal class Orc : Monster 
    {
        
        int AP = 500;
        int DP = 500;
        int S = 500;


        public void attackEnemy()
        {




        }
        public override void Die()
        {

            Console.WriteLine("This Orc died");


        }

    }
}
