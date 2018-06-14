using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Eddie = new Human("Eddie", 3, 3,3, 100);
            Human BMike = new Human("Mike", 3, 9, 3, 200);
            Console.WriteLine("Kick his axx S.B");
            Eddie.Attack(BMike);
            Console.WriteLine($"{Eddie.name} just kicked {BMike.name}'s A.., {BMike.name}'s health:{BMike.health}");
            Console.WriteLine($"{Eddie.intelligence}, {BMike.dexterity}");
        }
    }
}

