// LECTURE 6/10/25
using System.Collections.Generic;

namespace Program
{
    class Player
    {
        public string id;
        public string name;
        public string password;
        public int level;
        public Player(string id, string name, string password, int level)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.level = level;
        }
    }
    class WeaponStats
    {
        public string name;
        public int damage;

        public WeaponStats(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }
    class Weapon:WeaponStats
    {
        public string ownerID;
        public int level;
        public string weaponID;
        public Weapon(string name, int damage,string ownerID,int level,string weaponID) : base(name, damage)
        {
            this.ownerID = ownerID;
            this.level = level;
            this.weaponID = weaponID;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, WeaponStats> WeaponStatsDictionary = new Dictionary<string, WeaponStats>()
            {
                ["Sword"] = new WeaponStats("Sword", 2)
            };

            Dictionary<string, Weapon> WeaponSaves = new Dictionary<string, Weapon>() { };
            Dictionary<string, Player> PlayerSaves = new Dictionary<string, Player>() { };

            string IDGenerate()
            {
                string id = "";
                Random rand = new Random();
                for (int i = 0; i < 5; i++)
                {
                    id += rand.Next(0, 25).ToString();
                }
                return id;
            }
            string createWeaponID()
            {
                string id = IDGenerate();
                while (WeaponSaves.ContainsKey(id))
                {
                    id = IDGenerate();
                }
                return id;
            }
            string createPlrID()
            {
                string id = IDGenerate();
                while (PlayerSaves.ContainsKey(id))
                {
                    id = IDGenerate();
                }
                return id;
            }
            string currentPlayerID = "";
            bool loggedIn()
            {
                return currentPlayerID != "";
            }
            while (true)
            {
                Console.WriteLine("What would you like to do? \n1) Log in/Create Acc\n2) Create Weapon\n3) View Weapons");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1"://Log in 
                        if (loggedIn())
                        {
                            Console.WriteLine("You are already logged in");
                        }
                        else
                        {
                            void Login()
                            {
                                Console.WriteLine("Okay,\n1) Create Account\n2) Log In");
                                input = Console.ReadLine();
                                switch (input)
                                {
                                    case "1"://Create account
                                        Console.WriteLine("Enter your name:");
                                        string name = Console.ReadLine();
                                        Console.WriteLine("Enter your password:");
                                        string password = Console.ReadLine();
                                        Player createdPlayer = new Player(createPlrID(),input, password,1);
                                        PlayerSaves.Add(createdPlayer.id, createdPlayer);
                                        Console.WriteLine($"Account created! Your ID is {createdPlayer.id}");
                                        
                                        break;
                                    case "2"://Log in
                                        break;
                                    default:
                                        Console.WriteLine("Invalid input");
                                        Login();
                                        break;

                                }
                            }
                            Login();

                        }
                        break;
                    case "2"://Create Weapon
                        break;
                    case "3"://View Weapons
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}