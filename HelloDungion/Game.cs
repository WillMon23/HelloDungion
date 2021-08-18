using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungion
{
    class Game
    {
        public void Run()
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

            // Users name place holder
            string userName = "";

            // Job or task there will take on
            string userJob = "NOVISE";

            // Checks for Player Response
            string playerResponse = "";

            // Current level they reside in 
            int userLevel = 0;

            // Health value
            int userHealth = 0;

            // Hold Charaters Damage output
            int userDamage = 0;

            // Check for Correct Spelling on the job 
            float earningExp = 0;

            //Definds gameOver variable for use Later 
            bool gameOver = true;



            // Introduction
            Console.Write("So You Found Your Way Here Novise and Since Your Here I Can Only Assume You Came Here to Gain Some Leveles For Your Super Hero States \n");
            // Spaces Out The Lines So It Looks Cleaner 
            Console.ReadLine();


            // Takes User Input and Stores It in userName
            Console.WriteLine("Lets Start With Your Name, Seems Easy Enough \n");
            Console.WriteLine("> ");
            userName = Console.ReadLine();

            // Takes User Input and Stores It in userJob
            Console.WriteLine("So Tell me What Kind of Skill do You Posses, This is Important for This Will Dectate how much Exp You'll Gain");
            Console.ReadLine();

            // Asks from the veriations of occupation
            Console.WriteLine("Are You a 'Flying Enter (1)' Type");
            Console.WriteLine();
            Console.WriteLine("Are You a 'Speedster Enter (2)' Type ");
            Console.WriteLine();
            Console.WriteLine("Are You a 'Acrobatic Enter (3)' Type ");
            Console.WriteLine("> ");
            playerResponse = Console.ReadLine();

            //Users Resposnse in order to Dictate what will happen to the User 
            if (playerResponse == "1" || playerResponse == "Flyer") // Input Response to (1) or Flyer sets Characters capabilities 
            {
                userJob = "Flyer";
                Console.WriteLine("So I See You're a Flyer, not the strogest ability but has the better survivability of the other two ");
                userLevel = 20;
                earningExp += .05f;   

            }
            else if (playerResponse == "2" || playerResponse == "Speedster")
            {

                userJob = "Speedster";
                Console.WriteLine("So I See You're a Speedster, The Most Balanced of All the Other Classes ");
                userLevel = 10;
                earningExp += .1f;

            }
            else if (playerResponse == "3" || playerResponse == "Acrobatic")
            {
                userJob = "Acrobatic";
                Console.WriteLine("So I See a Acrobatic, The Strongest out off the Class but less likely to survive");
                userLevel = 5; 
                earningExp += 2;
            }
            else
                Console.WriteLine(" Sorry but this is not the place for you to level up, Try somewhere else or TRY AGAIN " + userJob);

            Console.ReadKey();
            Console.Clear();





            //Test Commit 





        }
    }
}