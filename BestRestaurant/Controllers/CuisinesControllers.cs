using BestRestaurant.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BestRestaurant.Controllers;

public class CuisinesController : Controller
{
  private readonly BestRestaurantContext _db;

  public CuisinesController(BestRestaurantContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    List<Cuisine> model = _db.Cuisines.ToList();
    return View(model);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Cuisine newCuisine)
  {
    _db.Cuisines.Add(newCuisine);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult Details(int fish)
  {
    Cuisine targetCuisine = _db.Cuisines.Include(burrito => burrito.Restaurants).FirstOrDefault(quesidilla => quesidilla.CuisineId == fish);
    return View(targetCuisine);
  }

  public ActionResult Edit(int id)
  {
    Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
    return View(thisCuisine);
  }
  [HttpPost]
  public ActionResult Edit(Cuisine cuisine)
  {
    _db.Cuisines.Update(cuisine);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
  public ActionResult Delete(int id)
  {
    Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
    return View(thisCuisine);
  }
  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
    _db.Cuisines.Remove(thisCuisine);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
}