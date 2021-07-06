using Akij_Food.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Akij_Food.AkijFoodData
{
    public interface IColdDrinkData
    {
        List<ColdDrink> GetColdDrinks();

        ColdDrink GetColdDrink(string name);

        ColdDrink GetColdDrink(int id);

        ColdDrink AddColdDrink(ColdDrink coldDrink);

        void DelelteColdDrinkItem(ColdDrink coldDrink);

        ColdDrink EditColdDrink(ColdDrink coldDrink);
    }
}
