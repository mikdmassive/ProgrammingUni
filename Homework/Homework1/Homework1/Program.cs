namespace Homework1
{
    using System;
    using static System.Net.Mime.MediaTypeNames;

    class Program
    {
        //classes
         class Person
        {
            public string id;
            public string fname;
            public string lname;
            public string password;
            public int floor = 0;
            public List<string> elevatorHistory = new List<string>();
            public  Person(string id,string fname,string lname,string password)
            {
                this.id = id;
                this.fname = fname;
                this.lname = lname;
                this.password = password;
            }
        }
        //data
        static Dictionary<string, Person> People = new Dictionary<string, Person>();

        public static int passwordMinLength = 8;
        public static int passwordMaxLength = 16;
        public static int passwordMinDigits = 2;

        public static bool loop = true;
        public static string currentuser = "";

        public static int bottomfloor = -2;
        public static int topfloor = 10;


        //methods
        public static string PasswordValidationCheck()
        {
            bool valid = false;
            string password = "";


            while (!valid)
            {
                password = Prompt("Enter your password");
                bool ws = false;
                if (password.Length >= passwordMinLength && password.Length <= passwordMaxLength)//len check
                {
                    int numCount = 0;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsDigit(password[i]))//digit check
                        {
                            numCount++;
                        }
                        else if (char.IsWhiteSpace(password[i]))//space check
                        {
                            ws = true;
                        }
                    }
                    valid = (numCount >= passwordMinDigits&&!ws);//setval
                    
                }
                if (!valid)//if not valid error message
                {
                    Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters and contain at least {passwordMinDigits} digits with no spaces.\nTry again.");
                }
            }
            return password;
        }
        public static string ValidateName(string txt)
        {
            string name = "";
            bool valid = false;
            while (!valid)
            {
                name = Prompt(txt);
                if (name.Length >= 1)
                {
                    valid = true;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if(!char.IsLetter(name[i]))
                        {
                            valid = false;
                        }    
                    }
                }
                if (!valid)
                {
                    Console.WriteLine("Invalid name, use only letters and be at least one character long.");
                }
            }
            return name;
                
        }
        public static void CreateAccount()
        {

            string fname = ValidateName("Enter your first name:");
            string lname = ValidateName("Enter your last name:");

            Console.WriteLine($"Create your password, it must...\n1) Be between {passwordMinLength} and {passwordMaxLength} characters \n2) Contain at least {passwordMinDigits} digits\n3) Contain no spaces");
            string password = PasswordValidationCheck();
            string id = $"PERSON{People.Count}";
            Person newPerson = new Person(id, fname, lname, password);
            People.Add(id, newPerson);
            Console.WriteLine($"Account created successfully! Your ID is {id}");
            currentuser = id;
        }
        public static void ManageAccounts()
        {
            string choice = Prompt("- ACCOUNT MANAGER -\nChoose an option:\n1) Create Account\n2) Log In\n3) Log Out\n4) Main Menu");
            switch (choice)
            {
                case "1"://create acc

                    CreateAccount();
                    break;
                case "2":// log in

                    if (People.Count == 0)
                    {
                        Console.WriteLine("There are no accounts in our database.");
                    }
                    else if (People.ContainsKey(currentuser))
                    {
                        Console.WriteLine("You are already logged in.");
                    }
                    else//checkpassword
                    {
                        string userID = Prompt("Enter your ID:");
                        if (People.ContainsKey(userID))
                        {
                            Person Account = People[userID];

                            bool passwordloop = true;
                            while (passwordloop)
                            {
                                string password = Prompt("Enter your password:");
                                if (password == Account.password)
                                {
                                    Console.WriteLine($"Welcome back, {Account.fname} {Account.lname}!");
                                    currentuser = userID;
                                    passwordloop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect password, try again.");
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("ID not found.");
                        }
                    }
                    break;
                case "3":// log out
                    if (currentuser != "")
                    {
                        currentuser = "";
                        Console.WriteLine("You are now logged out.");
                    }
                    else
                    {
                        Console.WriteLine("You are not logged in.");
                    }
                    break;
                case "4":

                    break;
                default:
                    Console.WriteLine("Invalid option, try again.\n");
                    ManageAccounts();
                    break;
            }
        }
        public static string Prompt(string txt)
        {

            Console.WriteLine(txt);
            return Console.ReadLine();
        }

        public static int SimulateElevator(string txt, int starterfloor)//ELEVATOR FLOOR CALC
        {
            int floor = starterfloor;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'u')
                {
                    floor++;
                }
                else if (txt[i] == 'd')
                {
                    floor--;
                }
            }
            return floor;
        }
       public static string ValidateElevator(int starterfloor)
        {
            bool valid = false;
            string txt = "";
            while (!valid)
            {
                txt = Prompt("Enter the elevator movements (u for up, d for down):");
                if (txt.Length>1)
                {
                    valid = true;
                }
                


                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(txt[i] == 'u' || txt[i] == 'd'))
                    {
                        valid = false;
                    }
                }
                if (valid)
                {
                    int floor = SimulateElevator(txt, starterfloor);
                    if (floor >= bottomfloor && floor <= topfloor)//floor check
                    {

                    }
                    else
                    {
                        Console.WriteLine($"Invalid movement, the elevator cannot go below floor {bottomfloor} or above floor {topfloor}. Try again.");
                        valid = false;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input, please use 'u' for up and 'd' for down.");
                }
            }
            return txt;

        }
        //main
        static void Main(string[] args)
        {
           
            // MAIN CODE
            Console.WriteLine("Welcome to the Elevator Account Management System!\n");
            while (loop)//LOOP
            {
                string choice = Prompt("-- MAIN MENU -- \nChoose an option:\n1) Manage Accounts\n2) Log Elevator Usage \n3) Elevator Use History\n4) Exit");
                switch (choice)
                {
                    case "1": //manageaccounts
                        ManageAccounts();
                        break;
                    case "2":// log elevator usage
                        if (currentuser == "")
                        {
                            Console.WriteLine("You must be logged in to log elevator usage.\n");
                        }
                        else
                        {
                            Person Account = People[currentuser];
                            Console.WriteLine($"The top floor is {topfloor}\nThe bottom floor is {bottomfloor}\nYou are currently on floor {Account.floor}.");
                            string movements = ValidateElevator(Account.floor);
                            Account.floor = SimulateElevator(movements, Account.floor);
                            Console.WriteLine($"You are now on floor {Account.floor}\n");
                            Account.elevatorHistory.Add(movements);//log use
                        }
                        break;
                    case "3":// elevator use history
                        if (currentuser == "")
                        {
                            Console.WriteLine("You must be logged in to view elevator use history.\n");
                        }
                        else
                        {
                            Person Account = People[currentuser];
                            if (Account.elevatorHistory.Count > 0)
                            {
                                int prevfloor = 0;
                                Console.WriteLine($"-- HISTORY ({Account.fname.ToUpper()} {Account.lname.ToUpper()}) --");
                                for (int i = 0; i < Account.elevatorHistory.Count; i++)
                                {
                                    string historyPattern = Account.elevatorHistory[i];
                                    int newfloor = SimulateElevator(historyPattern, prevfloor);
                                    Console.WriteLine($"{i + 1}: You took the elevator going \"{historyPattern}\" to floor {newfloor}");
                                    prevfloor = newfloor;
                                }
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("No elevator use history found.\n");
                            }
                        }
                            break;
                    case "4":// exit
                        Console.WriteLine("Goodbye!");
                        loop = false;
                        break;
                     default: // invalid
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }
        }
    }
}