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
        public int Gold { get; set; } = 0;

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
                if (enemy.Health <= 0)
                {
                    enemy.IsAlive = false;
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

            
            Player playerOne = new Player("Zach", 100, 10);
            Enemy enemyOne = new Enemy("Trogg", 50, 5);
            Enemy enemyTwo = new Enemy("Dragon", 1000, 50);
            string readConsole = "";
          

            Console.WriteLine("{0} appears! With a total of {1} health, do you wish to fight?", enemyOne.Name, enemyOne.Health);
            Console.WriteLine("\n Type Yes or No to continue....");
            readConsole = Console.ReadLine();

            if (readConsole == "Yes" || readConsole == "yes" || readConsole == "Sure" || readConsole == "sure")
            {
                Console.WriteLine("\n Great! You take on this dangerous challenge....");
                Console.WriteLine("\n What shall be your first move?\n Attack \n Loot \n Run \n");
                readConsole = Console.ReadLine();
            }

                while (playerOne.IsAlive || enemyOne.IsAlive)
                {
                    if (readConsole == "")
                    {
                    if (enemyOne.IsAlive == false)
                    {
                        Console.WriteLine("\n {0} has been defeated! You are a strong fighter indeed....", enemyOne.Name);
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        playerOne.Gold = playerOne.Gold + 50;
                        Console.WriteLine("Press >ENTER< To Continue....");
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                        break;
                    }
                    if (playerOne.IsAlive == false)
                    {
                        Console.WriteLine("You have died....");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("\n Input your next move now.... \n Attack \n Loot \n Hide \n");
                        readConsole = Console.ReadLine();
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                }
                    if (readConsole == "Attack" || readConsole == "attack") 
                    {
                        Console.WriteLine("\n Command recieved to attack!!!");
                        playerOne.DoDamageToEnemy(enemyOne);
                        Console.WriteLine(" You've landed a shot for {0} damage! \n{1} has {2} Health remaining.... \n", playerOne.Damage, enemyOne.Name, enemyOne.Health);
                    readConsole = "";
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    
                    
                    


                }
                    if (readConsole == "Loot" || readConsole == "loot")
                    {
                    Console.WriteLine("So you're looting are ya? \n You found a damage potion. \n Damage increased by 5....");
                    playerOne.Damage = playerOne.Damage + 5;
                    Console.WriteLine("New Damage: {0}", playerOne.Damage);
                    readConsole = "";
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();

                }
                if (readConsole == "Run" || readConsole == "run")
                {
                    Console.WriteLine("You run and survive.... \n Atleast for now.");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    break;
                    
                }


                
                    
                    

                }
            while (Console.ReadLine() != "Ready" || Console.ReadLine() != "ready")
            {
                ConsoleKeyInfo  cki;
                Console.WriteLine("Welcome back adventurer, choose where you want to go from camp....");
                Console.WriteLine("\n 1.Shop \n 2.Battle \n 3.Forging \n ....");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nWelcome to the shop! Here is what we currently have in shop! \n 1. Damage Potion - 75 Gold \n 2. Health Potion - 100 Gold");
                    Console.WriteLine("\n Although there isn't much, I would like for you to keep in mind that the damage and health potion will go over their normal maximum values!");
                }


            }
            
            Console.ReadLine();
        }
    }
}







