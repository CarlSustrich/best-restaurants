using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
namespace BestRestaurant.Controllers;


public class HomeController : Controller
{
  [Route("/")]
  public ActionResult Index() 
  {
    return View();
  }
}
