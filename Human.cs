using System;

namespace human
{
    public class Human
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public Human(string person ){
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp){
            name= person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void Attack(object obj){
            Human enemy = obj as Human;
            if(enemy == null){
                Console.WriteLine("Failed to Attack");
            }
            else{
                enemy.health -= strength * 5;
                intelligence -= dexterity *2; 
            }
        }
    }
}
