using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ravioli
{

    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Damage { get; set; }
        public bool IsAlive { get; set; }

        public Player(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
            IsAlive = true;
        }

        public void TakeDamageFromEnemy(Enemy enemy)
        {
            if (IsAlive)
            {
                Health -= enemy.Damage;
                if (Health <= 0)
                {
                    IsAlive = false;
                   
                }
            }
        }

        public void DoDamageToEnemy(Enemy enemy)
        {
            if (enemy.IsAlive)
            {
                enemy.Health -= Damage;
                if (Health <= 0)
                {
                    IsAlive = false;
                }
            }
        }
    }

    public class Enemy
    {

        public string Name;
        public int Health = 100;
        public int Damage;
        public string enemyMessages;
        public bool IsAlive { get; set; }

        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
            IsAlive = true;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {

            Player playerOne = new Player("Zach", 100, 20);
            Enemy enemyOne = new Enemy("Trogg", 15, 5);
            Enemy enemyTwo = new Enemy("Dragon", 1000, 50);
            string readConsole = "";
          
            Console.WriteLine("{0} appears! With a total of {1} health, he seems undefeatable to most, do you wish to fight?", enemyOne.Name, enemyOne.Health);
            Console.WriteLine("\n Type Yes or No to continue....");
            Console.ReadLine();
            if (readConsole == "Yes") {
                Console.WriteLine("\n Great! You take on this dangerous challenge....");
                Console.WriteLine("\n What shall be your first move?");
                Console.WriteLine("\n Your current options here are: Attack, Loot, or Hide. ");
                Console.ReadLine();
                while (playerOne.IsAlive && enemyOne.IsAlive)
                {
                    if (readConsole == "Attack")
                    {
                        Console.WriteLine("/n ATTACK YOU SAY? LET'S DO SOME DAMAGE!!!");
                        playerOne.DoDamageToEnemy(enemyOne);
                        Console.WriteLine("You've landed your first shot for {0} damage! Now that's a lot of damage. ({1} has {2} Health remaining....)", playerOne.Damage, enemyOne.Name, enemyOne.Health);
                    }
                    if (readConsole == "Loot")
                    {

                    }
                    if (readConsole == "Hide")
                    {
                        
                    }
                        
                    
                
}
                
                    }
            Console.ReadLine();
        }
    }
}







