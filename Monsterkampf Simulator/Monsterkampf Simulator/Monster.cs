using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monsterkampf_Simulator
{
    internal class Monster
    {


        public float ntattackPoints;
        public float defensePoints;
        public float attackSpeed;
        public float healthPoints;

        //Default Constructor



        public void attackEnemy()
        {



        }
        public virtual void Scream()
        {
            Console.WriteLine("Screaming");

        }
        public virtual void Die()
        {

            Console.WriteLine("This entity died");

        }
        
    }       
}







