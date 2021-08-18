using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungion
{
    class Game
    {
        int dummyCount;
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
            string userJob = "Novsie";
            // Current level they reside in 
            int userLevel = 0;
            // Check for Correct Spelling on the job 
            float earningExp = 0;




            // Introduction
            Console.Write("So You Found Your Way Here Novise and Since Your Here I Can Only Assume YOu Came Here to Gain Some Lelevs in Your Super Hero States");
            // Spaces Out The Lines So It Looks Cleaner 
            Console.ReadLine();
            // Takes User Input and Stores It in userName
            Console.WriteLine("Lets Start With Your Name Seems Easy Enough ");
            userName = Console.ReadLine();

            // Takes User Input and Stores It in userJob
            Console.WriteLine("So Tell me What You Currently do This is Important for This Will Dectate how much Exp You'll Gain");
            Console.ReadLine();
            Console.WriteLine("Are You a 'Flying' Type");
            Console.ReadLine();
            Console.WriteLine("Are You a 'Speedster' Type ");
            Console.ReadLine();
            Console.WriteLine("Are You a 'Acrobatic' Type ");
            Console.ReadLine();

            if (userJob == "Flayer")
            {
                earningExp += 12;

                if (userLevel <= 100)
                {

                }
            }
            if (userJob == "Speedster")
            {


                if (userLevel <= 100)
                {

                }
            }
            if (userJob == "Acrobotic")
            {


                if (userLevel <= 100)
                {

                }
            }




            Console.WriteLine(" With Quick Intro Ductions Aside " + userName);

            Console.WriteLine("");

            Console.Read();

        //Test Commit 





        }
    }
}
