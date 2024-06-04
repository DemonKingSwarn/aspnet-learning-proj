using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller {
    public string Index()
    {
        return "Hello Perseus Jackson, I am Hestia";
    }
}