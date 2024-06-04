using Microsoft.AspNetCore.Mvc;
using aspnet.Models;

namespace MvcMovie.Controllers;

public class LoginController : Controller {
    public IActionResult Index()
    {
        return View("Login");
    }

    public string Login(UserModel userModel)
    {
        return "Results: Username = " + userModel.Username + " PW = " + userModel.Password;
    }
}