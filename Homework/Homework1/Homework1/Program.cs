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

            public Person(string id,string fname,string lname,string password)
            {
                this.id = id;
                this.fname = fname;
                this.lname = lname;
                this.password = password;
            }
        }
        
        //main
        static void Main(string[] args)
        {
            //data
            Dictionary<string, Person> People = new Dictionary<string, Person>();

            int passwordMinLength = 8;
            int passwordMaxLength = 16;
            int passwordMinDigits = 2;
            //methods
            string PasswordValidationCheck()
            {
                bool valid = false;
                string password = "";


                while (!valid)
                {
                    password = Prompt("Enter your password");
                    if (password.Length >= passwordMinLength || password.Length <= passwordMaxLength)//len check
                    {
                        int numCount = 0;
                        for (int i = 0; i < password.Length; i++)
                        {
                            if (char.IsDigit(password[i]))//digit check
                            {
                                numCount++;
                            }
                        }
                        if (numCount >= passwordMinDigits)//check if valid
                        {
                            valid = true;
                        }
                    }
                    if (!valid)//if not valid error message
                    {
                        Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters and contain at least {passwordMinDigits} digits.\nTry again.");
                    }
                }
                return password;
            }
            void CreateAccount()
            {

                string fname = Prompt("Enter your first name");
                string lname = Prompt("Enter your last name");

                Console.WriteLine($"Create your password, it must...\n1) Be between {passwordMinLength} and {passwordMaxLength} characters \n2) Contain at least {passwordMinDigits} digits.");
                string password = PasswordValidationCheck();
                string id = $"PERSON{People.Count}";
                Person newPerson = new Person(id, fname, lname, password);
                People.Add(id, newPerson);
                Console.WriteLine($"Account created successfully! Your ID is {id}");
            }
            string Prompt(string txt)
            {

                Console.WriteLine(txt);
                return Console.ReadLine();
            }

            //main
            CreateAccount();
        }
    }
}