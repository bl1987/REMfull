using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REM.BL
{
    public class InventoryController
    {
        static public void AddInventory(Ingredient ingredient, IngredientInventory inventory)
        {
            var match = inventory.IngredientList.Where(i => i.Name == ingredient.Name).Count() > 0 ? true : false;
            if (match)
            {
                var index = inventory.IngredientList.FindIndex(i => i.Name == ingredient.Name);
                var totalWeight = inventory.IngredientList[index].Weight + ingredient.Weight;
                var totalValue = (decimal)inventory.IngredientList[index].Weight * inventory.IngredientList[index].Value +
                    (decimal)ingredient.Weight * ingredient.Value;
                inventory.IngredientList[index].Weight = totalWeight;
                inventory.IngredientList[index].Value = totalValue / (decimal)totalWeight;
            }
            else
            {
                inventory.IngredientList.Add(ingredient);
            }
        }
        static public void AddInventory(Drink drink, DrinkInventory inventory)
        {
            var match = inventory.DrinkList.Where(i => i.Name == drink.Name).Count() > 0 ? true : false;
            if (match)
            {
                var index = inventory.DrinkList.FindIndex(i => i.Name == drink.Name);
                var totalWeight = inventory.DrinkList[index].Quantity + drink.Quantity;
                var totalValue = (decimal)inventory.DrinkList[index].Quantity * inventory.DrinkList[index].Value +
                    (decimal)drink.Quantity * drink.Value;
                inventory.DrinkList[index].Quantity = totalWeight;
                inventory.DrinkList[index].Value = totalValue / (decimal)totalWeight;
            }
            else
            {
                inventory.DrinkList.Add(drink);
            }
        }
        static public bool DeleteInventory(Ingredient ingredient, IngredientInventory inventory)
        {
            var match = inventory.IngredientList.Where(i => i.Name == ingredient.Name).Count() > 0 ? true : false;
            if (match)
            {
                var index = inventory.IngredientList.FindIndex(i => i.Name == ingredient.Name);
                if (inventory.IngredientList[index].Weight >= ingredient.Weight)
                {
                    inventory.IngredientList[index].Weight -= ingredient.Weight;
                    if (inventory.IngredientList[index].Weight == 0)
                    {
                        inventory.IngredientList.RemoveAt(index);
                    }
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        static public bool DeleteInventory(Drink drink, DrinkInventory inventory)
        {
            var match = inventory.DrinkList.Where(i => i.Name == drink.Name).Count() > 0 ? true : false;
            if (match)
            {
                var index = inventory.DrinkList.FindIndex(i => i.Name == drink.Name);
                if (inventory.DrinkList[index].Quantity >= drink.Quantity)
                {
                    inventory.DrinkList[index].Quantity -= drink.Quantity;
                    if (inventory.DrinkList[index].Quantity == 0)
                    {
                        inventory.DrinkList.RemoveAt(index);
                    }
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
