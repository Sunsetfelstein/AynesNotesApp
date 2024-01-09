using Microsoft.AspNetCore.Mvc;

namespace AynesNotesApp.Controllers;

public class HomeController: Controller
{
    [Route("")]
    public string Index()
    {
        return "Hello World!";
    }
}