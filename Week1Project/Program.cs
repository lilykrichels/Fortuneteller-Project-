using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //I'm going to start by declaring all my variables needed in Part 1 so I can keep track of them easily
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string color;
            int siblings;
            int retirement;
            string vacationHome = String.Empty; //I kept getting an error message without adding this an an empty string saying that this value was not initiated
            string transport = String.Empty; //Both of these are initiated inside the body of an if else statement so this string help the cpmuter find them to initiate 
                                               //I don't quite understand how this works though, and am a little iffy about whether or not it's correct. 
                                               //Full disclosure I had help to figure this out, but want to follow up in class about the logic. 
           
            int money;


            Console.WriteLine("Welcome to FORTUNETELLER! To find out your future please enter your first name.");
            firstName = Console.ReadLine();
            //Here I am greeting the user and asking them for their first name. Then I am saving that as a string to use later.
            Console.WriteLine("Thank you " + firstName + ". Next please enter your lastname.");
            lastName =  Console.ReadLine();
            //Here I am greeting the user and asking for their last name, and saving that info as a string
            Console.WriteLine("Next enter your age in years.");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your birth month using a number. For example, May is 5.");
            birthMonth = int.Parse(Console.ReadLine());
            //I'm going to compile some if else statements right now under this question. 
            //That way it's in the same section so at the end, if I have a problem with the final promt I can easily go back.
            //There also won't be a bunch of if else statements for different things jammed together!!
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = 1000000;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = 5000;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = 79000;
            }
            else
            {
                money = 0;
            }
                    
            
            //Now we need to find out their favorite color! Ask the user and then save the info 
            Console.WriteLine("\nPlease enter your favorite ROYGBIV color.");
            Console.WriteLine("If you don't know what ROYGBIV is please write HELP");
            //Here we're asking the user for a color and also need to offer assistance. 
            //I used the method To.Lower to make sure the computer saves their input as something it can use later buy removing case sensitivity.
            color = Console.ReadLine();
            if (color.ToUpper() == "HELP")
                //.ToUpper will make sure the user gets "help" no matter how they type it in
            {
                Console.WriteLine("\nROYGBIV stands for Red, Yellow, Orange, Green, Blue, Indigo and Viloet.");
                Console.WriteLine("\nPlease pick a ROYGBIV color");
                color = Console.ReadLine();   
               //Re entering color's assignment makes sure that if they enter a second color after the promt the computer reads it            
             }
            if (color.ToUpper() == "RED")
            {
                transport = "bike";
            }
            else if (color.ToUpper() == "ORANGE")
            {
                transport = "horse";
            }
            else if (color.ToUpper() == "YELLOW")
            {
                transport = "ferryboat";
            }
            else if (color.ToUpper() == "GREEN")
            {
                transport = "rikshaw";
            }
            else if (color.ToUpper() == "BLUE")
                {
                transport = "VW Bug";
                }
            else if (color.ToUpper() == "INDIGO")
            {
                transport = "Piggy Back Ride";
            }
            else if (color.ToUpper() == "VIOLET")
            {
                transport = "limo";
            }
            Console.WriteLine("\nGreat. Finally, please enter the number of siblings you have.");
            
            //an if else statement is used to 
        

            siblings = int.Parse(Console.ReadLine());
            if (age % 2 == 0) 
             
            {
                retirement = 78;
            }
            else
            {
                retirement = 23;
            }

            if (siblings == 0)
            {
                vacationHome = "an arm pit";
            }
            else if (siblings == 1)
            {
                vacationHome = "Brussels";
            }
            else if (siblings == 2)
            {
                vacationHome = "a cave";
            }
            else if (siblings == 3)
            {
                vacationHome = "a wolf's den";
            }
            else if (siblings >= 4)
            {
                vacationHome = "a basement";
            }
            else
                vacationHome = "Antartica";
            //finally I need to write a line of script telling the user their fortune. 
            //This will be comepiled using a concatination. I also use \n to make things more readable. 

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retirement + " years with " + "$"+ money + ".00 " + "in the bank, \n a vacation home in " + vacationHome + " and a " + transport + "." );
            Console.WriteLine("\nThank you for playing and remember-");
            Console.WriteLine("\nAccept the things to which fate binds you, \nand love the people with whom fate brings you together, \nbut do so with all your heart. - Marcus Aurelius");
            //I like this quote and thought it might be nice to remind the user they can still enjoy their life even if they live in an armpit. 
        }
    
    }
}
 