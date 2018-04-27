using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheCounter.Models;
using System;

namespace TheCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/count")]
    public ActionResult Count()
    {
      RepeatCounter inputValues = new RepeatCounter(Request.Form["input-word"], Request.Form["input-text"]);
      inputValues.GetCount();                       //in case GetCount() was 'public int GetCount()', definition would be 'int finalCount = inputValues.GetCount();'
                                                    //'Console.WriteLine(finalCount);'
      return View("Index", inputValues);            //'return View("Index", finalCount);'
    }

  }
}
