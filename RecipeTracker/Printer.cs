using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker
{
    internal class Printer
    {

        public int choice;
        int i = 0;
        Boolean exitLoop = false;

        public void MainMenu()
        {

            Console.WriteLine("WELCOME TO THE RECIPE CREATOR\n=================================");
            Console.WriteLine("1. Create Recipe  2. Display Recipies  3. Scale Recipe  4. Delete Recipe  5. Exit");

        }

        public int displayRecipies(string[] recipies) //displays a list of all the recipies in alphabetical order
        {

            if (recipies.Length == 0) 
            { 
            
                Console.WriteLine("There are no recipies yet to display");
                return 1;
            }
            else
            {

                Console.WriteLine("List of Recipies");

                for (int i = 0; i < recipies.Length; i++)
                {

                    Console.WriteLine((i+1) + ". " + recipies[i]);
                    

                }
                return 2;

            }

        }
        public void PrintOutRecipe(string name, string[] ingredients, double[] amounts, string[] UOM, double[] calories, string[] foodGrp, string[] steps) //prints out the recipe
        {
            Console.WriteLine("Here is the recipe for " + name);
            Console.WriteLine("===================================");
            Console.WriteLine("");
            int iLength = ingredients.Length;
            Console.WriteLine("You will need the following ingredients");
            Console.WriteLine("");
            for (int i = 0; i < iLength; i++)
            {
                Console.WriteLine(amounts[i] + " " + UOM[i] + " of " + ingredients[i] + "(" + foodGrp[i] + ")" + " " + calories[i] + " Calories (a unit of energy, often used to express the nutritional value of foods, equivalent to the heat energy needed to raise the temperature of 1 kilogram of water by 1 °C)"); //https://www.google.com/search?client=firefox-b-d&q=what+are+calories
            }
            Console.WriteLine("\nHere are the steps taken to prepare the recipe");
            Console.WriteLine("=================================================");
            int sLength = steps.Length;
            for (int x = 0; x < sLength; x++)
            {
                Console.WriteLine(steps[x]);
            }
        }
        public int question() //asks the user weather they want to create a new recipe, scale the current recipe or exit the program
        {
            int answer = 0;
            Boolean exitLoop = false;

            Console.WriteLine("Would you like to create another recipe or scale the current one differently?\n1:New Recipe  2:Scale  3:Exit");

            //loops untill user enters a correct number
            while (!exitLoop)
            {

                int input = Int16.Parse(Console.ReadLine()); //takes in user input and converts it into an int

                //makes sure the user inputs the correct number
                if (input == 1 || input == 2 || input == 3)
                {
                    exitLoop = true;

                    switch (input)
                    {

                        case 1:
                            answer = 1;
                            break;
                        case 2:
                            answer = 2;
                            break;
                        case 3:
                            answer = 3;
                            break;


                    }

                }
                else
                {

                    Console.WriteLine("Would you like to create another recipe or scale the current one differently?\n1:New Recipe  2:Scale  3:Exit");

                }

            }


            return answer;
        }



    }
}
