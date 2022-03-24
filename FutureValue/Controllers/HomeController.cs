using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.FV = 0;
        ViewBag.Foot = "[= by learnTechFoundation and mrcsecit =]";
        ViewBag.link = "https://github.com/bertlandh/FutureValue.MVC";
        return View();
    }

    [HttpPost]
    public IActionResult Index(FutureValueModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.FV = model.CalculateFutureValue();
            ViewBag.Foot = "[= by learnTechFoundation and mrcsecit =]";
            ViewBag.link = "https://github.com/bertlandh/FutureValue.MVC";
        }
        else
        {
            ViewBag.FV = 0;
            ViewBag.Foot = "[= by learnTechFoundation and mrcsecit =]";
            ViewBag.link = "https://github.com/bertlandh/FutureValue.MVC";
        }
        return View(model);
    }
}