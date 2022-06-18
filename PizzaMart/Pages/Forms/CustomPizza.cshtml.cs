using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaMart.Models;

namespace PizzaMart.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty] public PizzasModel Pizza { get; private set; }

    public void OnGet()
    {
    }
}