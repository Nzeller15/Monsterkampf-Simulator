using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monsterkampf_Simulator
{
    internal class Monster
    {


        public float attackPoints;
        public float defensePoints;
        public float attackSpeed;
        public float healthPoints;

        //Default Constructor



        public Monster()
        {



        }
        public Monster(int _value)
        {
            Console.WriteLine("Value: " + _value);
        }

        public virtual void Attack(Monster _defendingMonster) //Attack methode erstellen
        {
            float damage = attackPoints - _defendingMonster.defensePoints;
            _defendingMonster.healthPoints = _defendingMonster.healthPoints - damage;

        }
    }       
}







