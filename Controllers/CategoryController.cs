using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    // GET: CategoryController.cs
    public IActionResult Index()
    {
        return View();
    }
}