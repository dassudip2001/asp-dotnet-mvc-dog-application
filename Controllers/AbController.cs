using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet.Models;

namespace dotnet.Controllers;


public class AbController : Controller
{

    private static List<DogViewModel> dogs= new List<DogViewModel>();
    public IActionResult Index()
    {
        // DogViewModel dogMode = new DogViewModel()
        // {
        //     Name="rocket",Age=2
        // };
        return View(dogs);
    }

    // When i can click nav ber
    public IActionResult Create()
    {

        var dognew=new DogViewModel();
        return View(dognew);
    }
    
    // create a new Dog
    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
    }

}