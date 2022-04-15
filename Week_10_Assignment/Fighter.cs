using System;


namespace Week_10_Assignment
{
    public class Fighter
    {
        public string name;

        public int currentHP;       
        public int maximumHP;

        public Boolean alive = true;

        public string combatant;  


        public Fighter(string n)
        {
            name = n;
        }

        public virtual int takeAction()
        {
            Console.WriteLine(" attacked " + combatant);
            return 0;
        }

        public void setMaxHP(int mHp)
        {
            maximumHP = mHp;
        }

        public void setCurrentHP(int cHp)
        {
            currentHP = cHp;
        }

        public void takeDamage(int Dmg)
        {
            Console.WriteLine(" " + name + " took " + Dmg + " damage.");
            Console.WriteLine("==========================");
            currentHP = currentHP - Dmg;

           

            if (currentHP <= 0)
            {
                HPcheck(currentHP);
            }
        }

        void HPcheck(int Hp)
        {
            if (currentHP <= 0)
            {
                Console.WriteLine(" " + name + " is downed.");
                currentHP = 0;
                alive = false;
            }
        }

       
    }
}
