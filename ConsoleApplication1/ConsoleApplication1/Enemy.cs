using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyNameSpace
{
    class Enemy
    {
        int health;
        public string name;
        public bool isRunning;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public Enemy()
        {
            health = 100;
            name = "Kwame";
            isRunning = true;
        }
        public Enemy(int eHealth, string eName, bool running)
        {
            health = eHealth;
            name = eName;
            isRunning = running;
        }
    }
}
