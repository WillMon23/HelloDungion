using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungion
{

    // values to for dementration
    //int health = 100; // value for health 
    //int healthRegen = 50; //values for health regen

    // Increases health by regeon ammount
    //health += 200; 
    //health += healthRegen;
    //healthRegen++;
    // Desplays the health and the current regeon ammount 
    //Console.Write("My Total Health Value " + health + " " + healthRegen ); 
    //Console.Read();

    // initialize variables for user insetation           
    //string name = "Empty";
    //Console.Write("Please Enter Your Name ");
    //name = Console.ReadLine();
    // Takes Input from the user

    //Console.WriteLine("So Your name is " + name);
    class Game
    {


        // Users name place holder
        public string userName = "";

        // Job or task there will take on
        public string userJob = "NOVICE";

        // Checks for Player Response
        public string playerResponse = "";

        // Current level they reside in 
        public int userLevel = 0;


        //Allocates a Certen vaule to cureent state of health
        public int numaratedHealth = 0;

        // Health stat
        public string userHealth = " "; 
        // Hold Charaters Damage output
        //public float userDamage = 0, enemyDamage = 40f;

        // Expirence Gain for Player and the Amount of Expirence GAined From enemy  
        //public float earningExp = 0, ExpGain = 50;

        //Definds gameOver variable
        public bool gameOver = true;

        public bool wrongInput = true;

        // If Player wants to play agin
        string playAgain = "";

        // Containts the abilities the charater
        public string[] abilities = new string[3];

        // Uses the variable to select where in the array 
        public int abilityNum = 0;

        // Function meant to display introduction to player
        void Introduction ()
        {
            // Introduction
            Console.Write("So You Found Your Way Here Novice and Since You're Here I Can Only Assume You Came Here to Gain Some Levels For Your Super Hero Stats.\n");
            // Spaces Out The Lines So It Looks Cleaner 
            ClearScreen();
            bool properResponse = false;
            while (!properResponse) {
                // Takes User Input and Stores It in userName
                Console.Write("Lets Start With Your Name, Seems Easy Enough, Right?\n");
                Console.Write("> ");
                userName = Console.ReadLine();

                // Takes User Input and Stores It in userJob
                Console.WriteLine("Now, Whats YOur Class? > ");
                Console.Clear();

                // Asks from the veriations of occupation
                Console.WriteLine("Are You a Type 'Flyer' or Type     '(1)' Type\n ");

                Console.WriteLine("Are You a Type 'Speedster' or Type '(2)' Type\n ");

                Console.WriteLine("Are You a Type 'Acrobatic' or Type '(3)' Type\n ");

                Console.Write("Enter Class Name or Number Assocaited With the Class > ");
                playerResponse = Console.ReadLine();

                if (playerResponse == "Flyer" || playerResponse == "Speedster" || playerResponse == "Acrobatic" || playerResponse == "1" || playerResponse == "2" || playerResponse == "3")
                    properResponse = true;
                
                else
                {
                    Console.WriteLine("Sorry But Can You Not Read Instructions? TRY AGIN!!!");
                    ClearScreen();
                    properResponse = false;
                }



                Console.Clear();

            }
        }

        // Fucntion Allows player to chhose there character class or skill
        void CharacterChoose()
        {
            //Users Resposnse in order to Dictate what will happen to the User Stats 

            // Input Response to (1) or Flyer then sets Characters capabilities 
            if (playerResponse == "1" || playerResponse == "Flyer") // Input Response to (1) or Flyer sets Characters capabilities 
            {
                userJob = "Flyer";
                Console.WriteLine("So I See You're a Flyer, Weakest Ability But Better Chance of Survival");
                userLevel = 20;

                numaratedHealth = 3;


                abilities = new string[] { "Gust", "WorldWind", "Dive Bomb", "Defend" };

            }
            // Input Response to (2) or Speedster then sets Characters capabilities 
            else if (playerResponse == "2" || playerResponse == "Speedster")
            {
                userJob = "Speedster";
                Console.WriteLine("So I See You're a Speedster, The Most Balanced of All the Other Classes. ");
                userLevel = 10;

                numaratedHealth = 2;

                abilities = new string[] { "Dash", "Tornado", "1000 Punches", "Defend" };

            }
            else if (playerResponse == "3" || playerResponse == "Acrobatic")
            {
                userJob = "Acrobatic";
                Console.WriteLine("So I See You're a Acrobatic, The Strongest out off the Class but less likely to survive.\n");
                userLevel = 5;

                numaratedHealth = 1;

                abilities = new string[] { "Sucker Punch", "Stun Gun", "Uses Weakness", "Defend" };
            }

            else
            {
                Console.WriteLine(" Sorry but this is not the place for you to level up, Try somewhere else or TRY AGAIN " + userJob + ".");
                gameOver = false;
            }
        }


        // Dispays charater stats to user  
        void PrintStats()
        {

            Console.WriteLine("So Your Name is: " + userName);
            Console.WriteLine("You'er Skilled as a " + userJob);
            Console.WriteLine("This Skill Comes With" +
                "\n\nStarting Level of " + userLevel +
                "\n\nCurrent Health: " + PlayerHealth(numaratedHealth));
               // "\n\nDamage Output of " + userDamage);
            Console.WriteLine("Your Abilities are: ");

            for (int i = 0; i < abilities.Length; i++)
                Console.WriteLine(abilities[i] + " (" + (i+1) + ") ");
            ClearScreen();

        }

        // Enemy stats and Interaction 
        bool HologramResponse()
        {

            string userResponse;

            Console.WriteLine("So Lets Start with some Hologram.");
  

            Console.WriteLine("Hologram Noticed You And Sprint to Attack");
            
            WhatsNext();

            userResponse = Console.ReadLine();

            abilityNum = AbilityLocation(userResponse);


            if (abilityNum == 3)
            {
                Console.WriteLine("Nice, You Went Under The Hologram's Attack and Left Him Vonrable  ");


                WhatsNext();

                userResponse = Console.ReadLine();

                abilityNum = AbilityLocation(userResponse);

                if (abilityNum >= 0 || abilityNum <= 2)
                {
                    Console.WriteLine("Critical Hit, Hologram Was Shareded With Your " + abilities[abilityNum] + "\n Hologram Lays On the Ground Dead\n Congrats!!!" +
                        " \nYou Earned: 15 Levels");

                    userLevel += 15;

                    Console.WriteLine("Your Current Level is " + userLevel);

                    Console.ReadKey();

                    return true;

                }
                else if (abilityNum >= 0 || abilityNum <= 2)
                {
                    userHealth = PlayerHealth(numaratedHealth -= 1);
                    Console.WriteLine("Your Defense Strtegy Failed\n Hologram Recovred\n Hologram Turns Towards");
                    Console.ReadKey();
                    Console.WriteLine("Hologram Truns Into a Cannon and Does His MEGA Cannon Attack");
                    if (numaratedHealth  != 0)
                    {
                        Console.WriteLine("Your Health Dropped to: \t" + userHealth + " Health");
                        return false; 
                    }
                    else
                        return true;

                }
                else
                {
                    Console.WriteLine("Invaled Input\n Try AGIN!!!");
                    return false;
                }

            }
            else if (abilityNum >= 0 || abilityNum <= 2)
            {
                Console.WriteLine("Big Oofs! Dummmy Dodged Your " + abilities[abilityNum] + " Attack, " +
                    "\n Dummies Trun" +
                    "\n Dummy Used Skull and Bone Attack");    

                Console.WriteLine(" You Took  Damage\n" +
                    "Your Heath Dropped to " + userHealth);

                return true;

            }
            else
            {

                Console.WriteLine("Invaled Input\n Try AGIN!!!");
                return false;
            }
            

            
        }

        string PlayerHealth(int healthLevel)
        {
            if (healthLevel == 0)
                return "Dead";
            else if (healthLevel == 1)
                return "Low";
            else if (healthLevel == 2)
                return "Medium";
            else if (healthLevel == 3)
                return "High";
            else
                return "Fix IT Will";

        }

        /// <summary>
        /// Turns Player Feed Back Into a Intager
        /// </summary>
        /// <param name="userResponse">Ability Use</param>
        /// <returns> Returns the Resposnse</returns>
        int AbilityLocation(string userResponse)
        {
            if (userResponse == "1")
                return 0;
            else if (userResponse == "2")
                return 1;
            else if (userResponse == "3")
                return 2;
            else if (userResponse == "4")
                return 3;
            else
                return 3;
        }

        // Clears Screen When Function is called  
        void ClearScreen()
        {
            Console.WriteLine("Press Any Key To Continue ");
            Console.ReadKey();
            Console.Clear();
        }

        //Just Types "What Will You Do Next"
        void WhatsNext()
        {

            Console.WriteLine("What Will You Decide NExt? \n");

            for (int i = 0; i < abilities.Length; i++)
                Console.WriteLine(abilities[i] + " (" + (i + 1) + ") ");
            
            Console.Write("> ");
        }

        public void Run()
        {

            while (gameOver)
            {
                // Displays Whole Introduction For the Player 
                Introduction();

                // Fucntion Allows player to chhose there character class or skill
                CharacterChoose();

                // Displays charater stats to user 
                PrintStats();



                gameOver = HologramResponse();


                ClearScreen();
                if (gameOver)
                {
                    while (wrongInput)
                    {

                        Console.WriteLine("Would You like to play again (y/n)?");
                        playAgain = Console.ReadLine();
                        if (playAgain == "y")
                        {
                            gameOver = true;
                            wrongInput = false;

                        }
                        else if (playAgain == "n")
                        {
                            gameOver = false;
                            wrongInput = false;
                        }
                        else
                            Console.WriteLine("Wrong Input Try AGIN!!");


                    }

                }
                

                ClearScreen();

            }

            //Test Commit 





        }
    }
}