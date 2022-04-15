using System;


namespace Week_10_Assignment
{
   public class Enemy : Fighter
    {

        Random random = new Random(); 

        public Enemy(string n) : base(n)
        {
            name = n;
        }

        public override int takeAction()
        {

            Console.WriteLine("==========================");
            Console.WriteLine(" " + name + " Hit " + combatant + " with a pan.");
            return 5 + (random.Next(6));
        }
    }
}
