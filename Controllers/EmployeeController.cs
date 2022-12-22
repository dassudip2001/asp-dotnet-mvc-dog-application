using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet.Models;

namespace dotnet.Controllers;


public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}