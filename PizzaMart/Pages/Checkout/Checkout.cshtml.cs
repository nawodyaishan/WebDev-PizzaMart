using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaMart.Pages.Checkout;

public class Checkout : PageModel
{
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; }
    public string PizzaImage { get; set; }

    public void OnGet()
    {
    }
}