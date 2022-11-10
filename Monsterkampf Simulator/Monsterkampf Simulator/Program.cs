using Monsterkampf_Simulator;
using System;
using System.Runtime.Intrinsics.Arm;


namespace Monsterkampf_Simulator
{
    internal class Program
    {


        static void Main(string[] args)
        {
          Orc orc1 = new Orc();
          Troll troll1 = new Troll();
          Goblin goblin1 = new Goblin();


            
            orc1.attackPoints = 500;
            orc1.defensePoints = 500;
            orc1.attackSpeed = 500;



            troll1.attackPoints = 1000;  
            troll1.defensePoints = 1000; 
            troll1.attackSpeed = 50;    
            

            goblin1.attackPoints = 100;
            goblin1.defensePoints = 200;
            goblin1.attackSpeed = 2000;
        }
    }
}
