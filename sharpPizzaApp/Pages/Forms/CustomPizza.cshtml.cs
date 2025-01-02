using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sharpPizzaApp.Model;

namespace sharpPizzaApp.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice=Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1394;
            if (Pizza.Peperoni) PizzaPrice += 3671;
            if (Pizza.Mushroom) PizzaPrice += 688;
            if (Pizza.Tuna) PizzaPrice += 2450;
            if (Pizza.Pineapple) PizzaPrice += 10000;
            if (Pizza.Ham) PizzaPrice += 1223;
            if (Pizza.Beef) PizzaPrice += 4567;

            return RedirectToPage("/Checkout/Checkout",new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
  