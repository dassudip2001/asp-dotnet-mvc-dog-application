using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet.Models;

namespace dotnet.Controllers;


public class AbController : Controller
{
    public IActionResult Index()
    {
        DogViewModel dogMode = new DogViewModel()
        {
            Name="rocket",Age=2
        };
        return View(dogMode);
    }
}