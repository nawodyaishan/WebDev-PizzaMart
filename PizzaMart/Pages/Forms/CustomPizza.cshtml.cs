using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaMart.Models;

namespace PizzaMart.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty] public PizzasModel Pizza { get; set; }
    public float PizzaPrice { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;

        if (Pizza.TomatoesSauce) PizzaPrice++;
        if (Pizza.Cheese) PizzaPrice++;
        if (Pizza.PineApple) PizzaPrice += 10;
        if (Pizza.Beef) PizzaPrice += 2;
        if (Pizza.Mushrooms) PizzaPrice += 3;
        if (Pizza.Tuna) PizzaPrice += 4;

        return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
    }
}