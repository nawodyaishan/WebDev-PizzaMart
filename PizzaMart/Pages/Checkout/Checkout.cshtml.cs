using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaMart.Pages.Checkout;

[BindProperties(SupportsGet = true)]
public class Checkout : PageModel
{
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; }
    public string PizzaImageTitle { get; set; }

    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName))
        {
            PizzaName = "Custom";
        }

        if (string.IsNullOrWhiteSpace(PizzaImageTitle))
        {
            PizzaImageTitle = "wooden.png";
        }
    }
}