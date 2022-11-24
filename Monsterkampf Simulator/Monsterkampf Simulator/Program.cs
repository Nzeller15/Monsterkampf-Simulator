using Monsterkampf_Simulator;
using System;
using System.Runtime.Intrinsics.Arm;


namespace Monsterkampf_Simulator
{
    internal class Program 
    {

        static Monster monster1;      // Die zwei Kämpfenden Monster erstellen
        static Monster monster2;

        static void Main(string[] args)
        {


            Intruduction();
            PickMonster();
           



           
        }
        static void Intruduction() 
        {
            Console.WriteLine("Hello my friend");
            Console.ReadKey();
            Console.WriteLine("You're now able to pick two monsters, which will Fight each other");
            Console.ReadKey();
            Console.WriteLine("The rules are simple, you only pick two monsters and each monster has to be from another race");
        
        }
        static void PickMonster() //Methode für die Monsterauswahl erstellen
        { 


        
        }
    }
}
