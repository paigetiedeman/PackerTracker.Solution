using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class PackerController : Controller
  {
    [HttpGet("/packer")]
    public ActionResult Index()
    {
      List<Packer> allItems = Packer.GetAll();
      return View(allItems);
    }
    
    [HttpGet("/packer/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/packer")]
    public ActionResult Create(string items)
    {
      Packer myItems = new Packer(items);
      return RedirectToAction("Index");
    }
    [HttpPost("/packer/delete")]
    public ActionResult DeleteAll()
    {
      Packer.ClearAll();
      return View();
    }

  }
}