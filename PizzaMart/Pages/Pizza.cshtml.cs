using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaMart.Models;

namespace PizzaMart.Pages;

public class Pizza : PageModel
{
    public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
    {
        new PizzasModel()
        {
            ImageTitle = "cheeseBrown",
            PizzaName = "Brown Cheese Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            FinalPrice = 4
        },
        new PizzasModel()
        {
            ImageTitle = "chickenpepper",
            PizzaName = "Chicken Pepper Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            Beef = true,
            Pepperoni = true,
            FinalPrice = 6
        },
        new PizzasModel()
        {
            ImageTitle = "boxnuggets",
            PizzaName = "Chicken Nuggets Box Pack",
            BasePrice = 3,
            TomatoesSauce = true,
            Cheese = true,
            FinalPrice = 3
        },
        new PizzasModel()
        {
            ImageTitle = "hawaiian",
            PizzaName = "Hawaiian Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            Ham = true,
            Tuna = true,
            FinalPrice = 5
        },
        new PizzasModel()
        {
            ImageTitle = "mushroom",
            PizzaName = "Vegetarian Mushroom Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            Mushrooms = true,
            FinalPrice = 3
        },
        new PizzasModel()
        {
            ImageTitle = "tastymushroom",
            PizzaName = "Exotic Mushroom Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            Beef = true,
            Ham = true,
            FinalPrice = 6
        },
        new PizzasModel()
        {
            ImageTitle = "vegetables",
            PizzaName = "Special Vege Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            Mushrooms = true,
            FinalPrice = 4
        },
        new PizzasModel()
        {
            ImageTitle = "wooden",
            PizzaName = "Wood Oven Special Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            Beef = true,
            Ham = true,
            FinalPrice = 4
        },
        new PizzasModel()
        {
            ImageTitle = "zucchini",
            PizzaName = "Italian Zucchini Pizza",
            BasePrice = 2,
            TomatoesSauce = true,
            Cheese = true,
            Tuna = true,
            FinalPrice = 4
        }
    };

    public void OnGet()
    {
    }
}