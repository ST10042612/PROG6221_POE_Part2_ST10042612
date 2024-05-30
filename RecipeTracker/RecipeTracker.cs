using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class recipeTracker
    {
        //All of these lists will keep track of the different recipies the user gives to the program. Their indexs correspond to data that is to be stored together.

        public List<string> recipeNames = new List<string>();//list of recipe names
        List<string[]> ingredients = new List<string[]>();//list of ingredients, ordered by recipe
        List<double[]> IAmounts = new List<double[]>();//list of the amount of a certain ingredient
        List<string[]> ingredientUOM = new List<string[]>();//list of the unit of mesurements used by a specific ingrendient
        List<double[]> ingredientCalories = new List<double[]>();//list of the unit of mesurements used by a specific ingrendient
        List<string[]> IFoodGrps = new List<string[]>();//list of the food group of ingredients
        List<string[]> recipeSteps = new List<string[]>();//list of the steps for a recipe


        public void storeAll(string name, string[] ingredients, double[] amounts, string[] UOM, double[] calories, string[] foodGrp, string[] steps)
        {

            this.recipeNames.Add(name);
            this.ingredients.Add(ingredients);
            this.IAmounts.Add(amounts);
            this.ingredientUOM.Add(UOM);
            this.ingredientCalories.Add(calories);
            this.IFoodGrps.Add(foodGrp);
            this.recipeSteps.Add(steps);

        }

        public void deleteRecipe(string name)
        {

            int index = this.recipeNames.IndexOf(name);

            this.recipeNames.RemoveAt(index);
            this.ingredients.RemoveAt(index);
            this.IAmounts.RemoveAt(index);
            this.ingredientUOM.RemoveAt(index);
            this.ingredientCalories.RemoveAt(index);
            this.IFoodGrps.RemoveAt(index);
            this.recipeSteps.RemoveAt(index);

        }

        public int getIndex(string str)
        {

            return recipeNames.IndexOf(str);

        }

        public string getRecipeName(int i)//returns the name of the array stored in a specific index of the recipeNames List
        {

            return recipeNames[i];

        }

        public string[] getIngredients(int i)//returns the name of the array stored in a specific index of the recipeNames List
        {

            return ingredients[i];

        }
        public double[] getIngredientAmounts(int i)//returns the name of the array stored in a specific index of the recipeNames List
        {

            return IAmounts[i];

        }
        public string[] getIngredientUOMs(int i)//returns the name of the array stored in a specific index of the recipeNames List
        {

            return ingredientUOM[i];

        }
        public double[] getIngredientCalories(int i)//returns the name of the array stored in a specific index of the recipeNames List
        {

            return ingredientCalories[i];

        }
        public string[] getIngredientFoodGroups(int i)//returns the name of the array stored in a specific index of the recipeNames List
        {

            return IFoodGrps[i];

        }

        public string[] getRecipeSteps(int i)//returns the name of the array stored in a specific index of the recipeNames List
        {

            return recipeSteps[i];

        }





    }



