using Microsoft.AspNetCore.Mvc;

namespace ProductCatalog.Controllers;

public class ProductsController : Controller
{
    // TODO: You will need to access the database to retrieve products
    // The ApplicationDbContext is already registered in Program.cs

    // TODO: Implement this action to return all active products
    // Return the Index view with the list of products
    public async Task<IActionResult> Index()
    {
        return View();
    }

    // TODO: Implement this action to return a specific product by id
    // Return the Details view with the product
    // Handle the case when product is not found
    public async Task<IActionResult> Details(int id)
    {
        return View();
    }


    // TODO: Implement this action to display product deletion confirmation View
    // Handle the case when product is not found 
    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        return View();
    }


    // TODO: Implement this action to delete a product by id
    // Return a redirect to the Index action
    // Handle the case when product is not found 
    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> ConfirmDeletion(int id)
    {
        //Implement product soft deletion logic here
        return RedirectToAction(nameof(Index));
    }
}
