using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ravioli
{
    
    public class Player
    {

        private string Name;
        private int Health = 100;
        private int Damage;
        public Player(string name, int health, int damage)
        {
            name = Name;
            health = Health;
            damage = Damage;
        }
        
    }
    public class Enemy
    {
        public void enemyTakeDamage()
        {
            int takenDamage;
            

        }
        private string Name;
        private int Health = 100;
        private int Damage;
        public string enemyMessages;
        public Enemy(string name, int health, int damage)
        {
            name = Name;
            health = Health;
            damage = Damage;
        }
        public Player P1 = new Player("Zach", 100, 20);
    }
    class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
