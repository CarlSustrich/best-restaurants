using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantContext _db;
    
    public RestaurantsController(BestRestaurantContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Restaurant> model = _db.Restaurants.ToList();
      
    //   return View(model);
    // }

    // public ActionResult Create()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Animal animal)
    // {
    //   _db.Animals.Add(animal);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details(int id)
    // {
    //   Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
    //   return View(thisAnimal);
    // }
}
}