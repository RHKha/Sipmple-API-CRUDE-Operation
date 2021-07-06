using Akij_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Akij_Food.AkijFoodData
{
    public class MockColdDrinkData : IColdDrinkData
    {
        private List<ColdDrink> coldDrinks = new List<ColdDrink>()
        {
            new ColdDrink()
            {
                intColdDrinksId = 1,
                strColdDrinksName = "Test 1",
                numQuantity = 50,
                numUnitPrice = 20
            },

            new ColdDrink()
            {
                intColdDrinksId = 2,
                strColdDrinksName = "Test 2",
                numQuantity = 50,
                numUnitPrice = 20
            },

            new ColdDrink()
            {
                intColdDrinksId = 3,
                strColdDrinksName = "Test 3",
                numQuantity = 50,
                numUnitPrice = 20
            }
        };
        public ColdDrink AddColdDrink(ColdDrink coldDrink)
        {
            coldDrink.intColdDrinksId = coldDrink.intColdDrinksId;
            coldDrinks.Add(coldDrink);
            return coldDrink;
        }

        public void DelelteColdDrinkItem(ColdDrink coldDrink)
        {
            coldDrinks.Remove(coldDrink);
        }

        public ColdDrink EditColdDrink(ColdDrink coldDrink)
        {
            var existingColdrink = GetColdDrink(coldDrink.intColdDrinksId);
            existingColdrink.strColdDrinksName = coldDrink.strColdDrinksName;
            existingColdrink.numQuantity = coldDrink.numQuantity;
            existingColdrink.numUnitPrice = coldDrink.numUnitPrice;

            return existingColdrink;
        }

        public ColdDrink GetColdDrink(string name)
        {
            return coldDrinks.SingleOrDefault(x => x.strColdDrinksName == name);
        }

        public ColdDrink GetColdDrink(int id)
        {
            return coldDrinks.SingleOrDefault(x => x.intColdDrinksId == id);
        }

        public List<ColdDrink> GetColdDrinks()
        {
            return coldDrinks;
        }
    }
}
