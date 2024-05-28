using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SpecialTask_2.Models;

namespace SpecialTask_2.Controllers;
public class HomeController : Controller
{
    static PasswordPolicy passwordPolicy = new PasswordPolicy();
    // GET: Home
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Index(int minLength, int lowercase, int uppercase, int
    numeric, int special_char)
    {
        passwordPolicy.minLength = minLength;
        passwordPolicy.lowercase = lowercase;
        passwordPolicy.uppercase = uppercase;
        passwordPolicy.special_char = special_char;
        passwordPolicy.numeric = numeric; return
        RedirectToAction("Password");
    }
    public ActionResult Password()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Password(string password)
    {
        string errormsg = "Password matched with given policy";
        int lowercase = 0, uppercase = 0, special_char = 0, numeric = 0;
        for (int i = 0; i < password.Length; i++)
        {
            if (password[i] >= 65 && password[i] <= 90) uppercase++;
            else if (password[i] >= 97 && password[i] <= 122) lowercase++;
            else if (password[i] >= 48 && password[i] <= 57) numeric++;
            else special_char++;
        }
        if (password.Length < passwordPolicy.minLength || lowercase <
        passwordPolicy.lowercase ||
        uppercase < passwordPolicy.uppercase || numeric <
        passwordPolicy.numeric ||
        special_char < passwordPolicy.special_char)
        {
            errormsg = "Entered password does not match required policy";
        }
        ViewBag.errormsg = errormsg;
        return View();
    }
}
//public class HomeController : Controller
//{
//    private readonly ILogger<HomeController> _logger;

//    public HomeController(ILogger<HomeController> logger)
//    {
//        _logger = logger;
//    }

//    public IActionResult Index()
//    {
//        return View();
//    }

//    public IActionResult Privacy()
//    {
//        return View();
//    }

//    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//    public IActionResult Error()
//    {
//        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//    }

//}

