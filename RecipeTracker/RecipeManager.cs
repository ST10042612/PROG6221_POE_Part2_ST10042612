using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class RecipeManager
{

    //variable declaration
    int ingredientListSize, stepSize;
    double totalCal;
    public string recipeName;
    public ArrayList ingredientName = new ArrayList();
    public ArrayList ingredientQuantity = new ArrayList();
    public ArrayList ingredientUOM = new ArrayList();
    public ArrayList ingredientFoodGrp = new ArrayList();
    public ArrayList ingredientCalories = new ArrayList();
    public ArrayList steps = new ArrayList();



    public void CreateRecipe()//Creates a new recipe based off of user input
    {
        //asks user for the name of the recipe then adds that input into a string named recipe
        Console.WriteLine("Please enter the name of the recipe you would like to create.");
        recipeName = Console.ReadLine();

        //asks the user to input how many ingredients are in the recipe, then adds that number into an int named ingredientAmount
        Console.WriteLine("How many ingredients are there in this recipe?");
        ingredientListSize = Int16.Parse(Console.ReadLine());

        //the user will enter each ingredients name, quantity and its Unit of mesurement, this will then be input into the respective arraylist.
        for (int i = 0; i < ingredientListSize; i++)
        {

            Console.WriteLine("Enter an ingredients name:");
            ingredientName.Add(Console.ReadLine());

            Console.WriteLine("Enter the quantity of the ingredient:");
            ingredientQuantity.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Enter the ingredients unit of mesurement:");
            ingredientUOM.Add(Console.ReadLine());

            Console.WriteLine("Enter the ingredients unit of Food Group:");
            ingredientUOM.Add(Console.ReadLine());

            Console.WriteLine("Enter the ingredients total amount of calories:");
            ingredientUOM.Add(Console.ReadLine());

            Console.WriteLine("");
        }

        //asks the user to input how many steps the recipe has, then adds that number into an int named stepAmount
        Console.WriteLine("How many steps are there in this recipe?");
        stepSize = Int16.Parse(Console.ReadLine());

        //the user will enter each step, this will then be input into the respective arraylist.
        for (int x = 0; x < stepSize; x++)
        {

            Console.WriteLine("Please enter a step");
            steps.Add(Console.ReadLine());

        }



    }

    
    public double[] ScaleRecipe(double[] q) //This function will determine by what factor the user would like to scale the recipe by and then it will apply the users choice to the ingredientQuantity Array
    {

        //variable declaration
        Boolean exitLoop = false;
        double input;
        string temp;

        while (exitLoop)
        {
            Console.WriteLine("How would you like to scale your recipe?\n(example: 2 for double or 0.5 for half)");
            try
            {
                exitLoop = true;

                temp = Console.ReadLine();

                input = Convert.ToDouble(temp); //takes in user input and converts it into a double


                for (int i = 0; i < ingredientQuantity.Count; i++)
                {

                    ingredientQuantity[i] = q[i] * input;

                }

            }
            catch (Exception)
            {

                Console.WriteLine("incorrect input try again");

            }
        }

        return q;


    }
    

    public void ClearRecipie() //clears all the arrays and the recipe values
    {

        recipeName = "";
        ingredientName.Clear();
        ingredientQuantity.Clear();
        ingredientUOM.Clear();
        steps.Clear();

    }

    public double clacCalories(double[] cal)
    {
        for (int i = 0; i < cal.Length; i++)
        {

            totalCal += cal[i];

        }


        return totalCal;
    }

    public void checkCalories(double totalCal)
    {

        if (totalCal > 300)
        {

            Console.WriteLine("The total calories exeed 300");
            Console.WriteLine("a unit of energy, often used to express the nutritional value of foods, equivalent to the heat energy needed to raise the temperature of 1 kilogram of water by 1 °C");//https://www.google.com/search?client=firefox-b-d&q=what+are+calories

        }
        else
        {

            Console.WriteLine("The total calories do not exeed 300");

        }

    }


}
;