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
        public string userJob = "NOVISE";

        // Checks for Player Response
        public string playerResponse = "";

        // Current level they reside in 
        public int userLevel = 0;

        // Health stat
        public string userHealth = " "; //enemyHealth = 200;
        // Hold Charaters Damage output
        //public float userDamage = 0, enemyDamage = 40f;

        // Expirence Gain for Player and the Amount of Expirence GAined From enemy  
        //public float earningExp = 0, ExpGain = 50;

        //Definds gameOver variable
        public bool gameOver = true;

        // Containts the abilities the charater
        public string[] abilities = new string[3];

        public int abilityNum = 0;

        // Function meant to display introduction to player
        void Introduction ()
        {
            // Introduction
            Console.Write("So You Found Your Way Here Novise and Since Your Here I Can Only Assume You Came Here to Gain Some Leveles For Your Super Hero Stats. \n");
            // Spaces Out The Lines So It Looks Cleaner 
            Console.ReadLine();


            // Takes User Input and Stores It in userName
            Console.WriteLine("Lets Start With Your Name, Seems Easy Enough \n");
            Console.Write("> ");
            userName = Console.ReadLine();

            // Takes User Input and Stores It in userJob
            Console.WriteLine("So Tell me What Kind of Skill do You Posses, This is Important for This Will Dectate how much Exp You'll Gain.");
            Console.ReadLine();

            // Asks from the veriations of occupation
            Console.WriteLine("Are You a 'Flying or Enter '(1)' Type");
            Console.WriteLine();
            Console.WriteLine("Are You a 'Speedster or Enter '(2)' Type ");
            Console.WriteLine();
            Console.WriteLine("Are You a 'Acrobatic or Enter '(3)' Type ");
            Console.Write("> ");
            playerResponse = Console.ReadLine();
        }

        // Fucntion Allows player to chhose there character class or skill
        void CharacterChoose()
        {
            //Users Resposnse in order to Dictate what will happen to the User Stats 

            // Input Response to (1) or Flyer then sets Characters capabilities 
            if (playerResponse == "1" || playerResponse == "Flyer") // Input Response to (1) or Flyer sets Characters capabilities 
            {
                userJob = "Flyer";
                Console.WriteLine("So I See You're a Flyer, not the strogest ability but has the better survivability of the other two ");
                userLevel = 20;

                //userHealth = 2500;
                //earningExp += .05f;

                //userDamage = userLevel * earningExp;

                abilities = new string[] { "Gust", "WorldWind", "Dive Bomb", "Defend" };

            }
            // Input Response to (2) or Speedster then sets Characters capabilities 
            else if (playerResponse == "2" || playerResponse == "Speedster")
            {
                userJob = "Speedster";
                Console.WriteLine("So I See You're a Speedster, The Most Balanced of All the Other Classes. ");
                userLevel = 10;

                //userHealth = 2000;
                //earningExp += .1f;

                //userDamage = userLevel * earningExp;

                abilities = new string[] { "Dash", "Tornado", "1000 Punches.", "Defend" };

            }
            else if (playerResponse == "3" || playerResponse == "Acrobatic")
            {
                userJob = "Acrobatic";
                Console.WriteLine("So I See a Acrobatic, The Strongest out off the Class but less likely to survive.");
                userLevel = 5;

                //userHealth = 1000;
                //earningExp += 2f;

                //userDamage = userLevel * earningExp;

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
            Console.WriteLine("Your Skilled as a " + userJob);
            Console.WriteLine("This Skill Comes With" +
                "\n\nStarting Level of " + userLevel +
                "\n\nCurrent Health HEALTHY");
               // "\n\nDamage Output of " + userDamage);
            Console.WriteLine("You're also going to be equiped with new abilities" +
                "\nYour Abilities are: ");

            for (int i = 0; i < abilities.Length; i++)
                Console.WriteLine(abilities[i] + " (" + (i+1) + ") ");

        }

        // Enemy stats and Interaction 
        void DummyResponse()
        {
            bool fightingDummy = true;
            string userResponse = "";


            while (fightingDummy)
            {
                Console.WriteLine("So Lets start with some dummies.");

                WhatsNext();

                Console.WriteLine("Dummy Noticed You And Sprints to Attack\n Player Turn ");

                userResponse = Console.ReadLine();

                abilityNum = AbilityLocation(userResponse);


                if (abilityNum == 3)
                {
                    Console.WriteLine("Nice You Went Under The Dummys Attack and Left Him Vonrable  ");

                   

                    WhatsNext(); 
                    
                    userResponse = Console.ReadLine();
                    
                    abilityNum = AbilityLocation(userResponse);

                    if (abilityNum >=0 || abilityNum <= 2)
                    {
                        Console.WriteLine("Critical Hit, Dummy Was Shareded With Your " + abilities[abilityNum] + "\n Dummy Lays On the Ground Dead\n Congrats!!!" +
                            " \nYou Earned: 15 Levels");

                        userLevel += 15;

                        Console.WriteLine("Your Current Level is " + userLevel);
                    }
                    else
                    {
                        //Do Thing
                    }
                }
                else if (abilityNum >= 0 || abilityNum <= 2)
                {
                    Console.WriteLine("Big Oofs! Dummmy Dodged Your " + abilities[abilityNum] + " Attack, Dummy Used Skull and Bone Attack");

                    Console.WriteLine(" You Took  Damage");

                    userHealth = "Medium";
                }
                else
                {
                    Console.WriteLine("Invaled Input\n Try AGIN!!!");
                }

            }
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
                return 4; 
        }

        // Clears Screen When Function is called  
        void ClearScreen()
        {
            Console.ReadKey();
            Console.Clear();
        }

        //Just Types "What Will You Do Next"
        void WhatsNext()
        {
            Console.WriteLine("What Will You Do Next");
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

                // Clears SCrene
                ClearScreen();

                DummyResponse();

                while (gameOver)
                {
                    if (userHealth == "Dead" || userLevel >= 100)
                        gameOver = false;



                }

                ClearScreen();


            }

            //Test Commit 





        }
    }
}