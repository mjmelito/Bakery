using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Bakery.Models;
using Bakery.ViewModels;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryContext _db;

    public HomeController(BakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
    var treats = _db.Treats.ToList();
    var flavors = _db.Flavors.ToList();

    var viewModel = new TreatFlavorViewModel
    {
        Treats = treats,
        Flavors = flavors
    };

    return View(viewModel);
    }
  }
}