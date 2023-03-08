using System;
using System.Collections.Generic;
namespace BestRestaurant.Models;

  public class Restaurant
  {
    public int RestaurantId {get;set;}
    public string RestaurantName {get;set;}
    public Cuisine Cuisine {get;set;}
    public int CuisineId {get;set;}
  }