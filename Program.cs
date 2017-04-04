using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
    public class Human{
        public string name;
        public int strength = 3;
        public int intelligece = 3;
        public int dexterity = 3;
        public int health = 100;  
        public Human(string newName){
            name = newName;
        }
        public Human(string newName, int newStrength, int newIntell, int newDex, int newHealth){
            name = newName;
            strength = newStrength;
            intelligece = newIntell;
            dexterity = newDex;
            health = newHealth;
        }
        public void Attack(Human opponent){
           opponent.health -= (strength * 5);
        }
         public void Attack(object opponent){
            if (opponent is Human){
                (opponent as Human).health-= (strength * 5);
            }
           
        }
    }
}