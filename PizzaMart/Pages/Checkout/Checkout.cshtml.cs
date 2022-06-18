using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaMart.Pages.Checkout;

[BindProperties]
public class Checkout : PageModel
{
    public string PizzaName { get; set; }
    public float PizzaPrice { get; set; }
    public string PizzaImage { get; set; }

    public void OnGet()
    {
    }
}