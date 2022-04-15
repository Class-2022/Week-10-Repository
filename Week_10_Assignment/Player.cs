using System;


namespace Week_10_Assignment
{
    public class Player : Fighter
    {
        public int chocolatePieces = 7; 


        Random random = new Random(); 

        public Player(string n) : base(n) 
        {
            name = n;
        }

         public void eatChocolate()
        {
            if (chocolatePieces > 0)
            {
                Console.WriteLine(name + " eats a piece of chocolate +" + (currentHP / 4) + " to health points.");

                chocolatePieces--; 

                currentHP += (maximumHP / 4); 

                if (currentHP >= maximumHP) 
                {
                    currentHP = maximumHP;
                }

            }
            else if (chocolatePieces <= 0)
            {
                Console.WriteLine(name + " is out of chocolate");
            }
        }

        public override int takeAction() 
        {
            int choice = 0;

            do
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("==========================");
                        Console.WriteLine(" Squirrel hit " + combatant + " with a bat.");
                        return 5 + (random.Next(6));
                    }
                    else if (choice == 2)
                    {
                        eatChocolate();
                        return 0;
                    }
                    else
                        Console.WriteLine("Invalid input");
                }
                catch (Exception)
                {

                    Console.WriteLine("invalid input");
                } 
               
               
            } while (choice != 1 || choice != 2);



            return 0;
        }

       
    }
}
