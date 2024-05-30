using RecipeTracker;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    public delegate void calWarning(double a);
    private static void Main(string[] args)
    {
        //Variable declaration
        Printer printer = new Printer();
        RecipeManager rm = new RecipeManager();
        recipeTracker rt = new recipeTracker();
        Boolean exitLoop = false;
        int index, tempIndex;

        

        while (!exitLoop)
        {

            printer.MainMenu();

                int choice = Int16.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        rm.CreateRecipe();

                        string name = rm.recipeName;
                        string[] ingredientName = (string[])rm.ingredientName.ToArray(typeof(string));
                        double[] ingredientQuantity = (double[])rm.ingredientQuantity.ToArray(typeof(double));
                        string[] ingredientUOM = (string[])rm.ingredientUOM.ToArray(typeof(string));
                        double[] ingredientCalories = (double[])rm.ingredientCalories.ToArray(typeof(double));
                        string[] ingredientFoodGrp = (string[])rm.ingredientFoodGrp.ToArray(typeof(string));
                        string[] steps = (string[])rm.steps.ToArray(typeof(string));

                        Console.WriteLine("===========================");
                        Console.WriteLine("Total Calories:" + rm.clacCalories(ingredientCalories));
                        
                        calWarning calWarning = new calWarning(rm.checkCalories);

                        calWarning(rm.clacCalories(ingredientCalories));

                        rt.storeAll(name, ingredientName, ingredientQuantity, ingredientUOM, ingredientCalories, ingredientFoodGrp, steps);

                        break;

                    case 2: // This code block will display a list of recipies in alphabetical order and then determine which recipie was being reffered to and display said recipe in full

                        Console.Clear();

                        string[] tempDisplay = new string[rt.recipeNames.Count];

                        rt.recipeNames.CopyTo(tempDisplay);

                        Array.Sort(tempDisplay);

                        if (printer.displayRecipies(tempDisplay) == 2)
                        {

                            Console.WriteLine("\nWhich recipe do you wish to display?, please enter a number");
                            tempIndex = Int16.Parse(Console.ReadLine()) - 1;

                            index = rt.getIndex(tempDisplay[tempIndex]);

                            Console.WriteLine(index);

                            printer.PrintOutRecipe(rt.getRecipeName(index), rt.getIngredients(index), rt.getIngredientAmounts(index), rt.getIngredientUOMs(index), rt.getIngredientCalories(index), rt.getIngredientFoodGroups(index), rt.getRecipeSteps(index));

                            tempIndex = 0;
                            index = 0;


                        }


                        

                        break;

                    case 3:

                        Console.Clear();

                        string[] tempDisplayy = new string[rt.recipeNames.Count];

                        rt.recipeNames.CopyTo(tempDisplayy);

                        Array.Sort(tempDisplayy); 

                        if (printer.displayRecipies(tempDisplayy) == 2)
                        {


                            Console.WriteLine("\nWhich recipe do you wish to display?, please enter a number");
                            tempIndex = (Int16.Parse(Console.ReadLine()) - 1);

                            index = rt.getIndex(tempDisplayy[tempIndex]);

                            printer.PrintOutRecipe(rt.getRecipeName(index), rt.getIngredients(index), rm.ScaleRecipe(rt.getIngredientAmounts(index)), rt.getIngredientUOMs(index), rt.getIngredientCalories(index), rt.getIngredientFoodGroups(index), rt.getRecipeSteps(index));

                            tempIndex = 0;
                            index = 0;


                        }

                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine("Please enter the name of the recipe you wish to delete");

                        try 
                        {

                            string input = Console.ReadLine();

                            rt.deleteRecipe(input);

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Please enter a valid name next time");
                        
                        }

                        

                        break;

                    case 5:

                        exitLoop = true;

                        break;

                    default:

                        Console.WriteLine("Not an option");

                        break;

                }

            
            

            //Console.Clear();

        }

    }
}
