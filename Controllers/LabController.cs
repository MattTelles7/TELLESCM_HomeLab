using Microsoft.AspNetCore.Mvc;

namespace HomeLab.Controllers;

public class LabController : Controller
{
    public IActionResult Index() => View();
    public IActionResult GameServers() => View();
    public IActionResult MediaServers() => View();
}
