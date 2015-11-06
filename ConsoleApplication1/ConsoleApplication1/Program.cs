using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyNameSpace;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable for stopping the while loop
            int stopValue = 1;
            Enemy myEnemy = new Enemy();
            Enemy myEnemy2 = new Enemy(23, "Joe Enemy", true);
            // players health variable
            int playerHealth = 100;
            // 
            int timeStep = 60;
            int someCrazyTimeStep = 1000;
            // construct the while loop
            while (stopValue != 0)
            {
                // grab the time step
                // if the returned time step is greater than our locked time step set it back
                if(someCrazyTimeStep > timeStep)
                {
                    // set it back
                    someCrazyTimeStep = timeStep;
                }
                // 
                Console.WriteLine("Enter 1 to continue or 0 to exit");
                string toStringValue = Console.ReadLine();
                int.TryParse(toStringValue, out stopValue);
                addDamageToPlayer(ref playerHealth);
            }
        }
        // Pass by Value and Pass by Reference
        public static void addDamageToPlayer(ref int Health)
        {
            Health--;
            Console.WriteLine("{0}", Health);
        }
        public static string returnEnemyName(string name)
        {
            return name;
        }
        public static Enemy returnNewEnemy(Enemy enemy)
        {
            return enemy;
        }
    }

}
