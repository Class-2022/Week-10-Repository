using System;

namespace Week_10_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player("Squirrel");
            Enemy enemy = new Enemy("Teddy");


            player.combatant = enemy.name;
            enemy.combatant = player.name;


            player.maximumHP = 50;
            player.currentHP = 50;


            enemy.maximumHP = 50;
            enemy.currentHP = 50;


            Fighter[] combat = new Fighter[2];
            combat[0] = player;
            combat[1] = enemy;


            int damage = 0;


            Boolean firstTurn = true;
            Boolean playerTurn = true;


            Boolean Battle = true;


            while (Battle == true)
            {
                foreach (Fighter a in combat)
                {
                    if (firstTurn == true || Battle == false)
                    {
                        firstTurn = false;
                    }
                    else
                    {
                        a.takeDamage(damage);
                    }


                    if (a.alive == false)
                    {
                        Battle = false;
                    }
                    else
                    {
                        if (Battle == true)
                        {
                            if (playerTurn == true)
                            {
                                playerTurn = false;

                                Console.WriteLine(" ________________________________");
                                Console.WriteLine("| " + player.name + " HP: " + player.currentHP);
                                Console.WriteLine("| " + enemy.name + " HP: " + enemy.currentHP);
                                Console.WriteLine("|________________________________");
                                Console.WriteLine("| press 1 or 2 and press enter.");
                                Console.WriteLine("| 1 - Fight");
                                Console.WriteLine("| 2 - Pieces of Hp chocolate left - " + player.chocolatePieces);
                                Console.WriteLine("|________________________________");
                                damage = a.takeAction();
                            }
                            else
                            {
                                playerTurn = true;
                                damage = a.takeAction();
                            }
                        }
                        else
                        {

                        }
                    }

                }
            }

            if (player.alive == true)
            {
                Console.WriteLine("\n Squirrel has won with a knock out.");
            }
            else
            {
                Console.WriteLine("\n Squirrel is unconscious and can not continue.");
            }

        }
    }
}
