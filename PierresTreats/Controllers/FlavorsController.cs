using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  [Authorize]
  public class FlavorsController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorsController(UserManager<ApplicationUser> userManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [AllowAnonymous]
    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      if (!ModelState.IsValid)
      {
        return View(flavor);
      }
      else
      {
        _db.Flavors.Add(flavor);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    [AllowAnonymous]
    public ActionResult Details(int id)
    {
      ViewBag.Treats = _db.Treats.ToList();
      Flavor thisFlavor = _db.Flavors
        .Include(flavor => flavor.JoinEntities)
        .ThenInclude(join => join.Treat)
        .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    public ActionResult Edit(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddTreat(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult AddTreat(Flavor flavor, int TreatId)
    {
      if (TreatId != 0)
      {
        _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTreat(int joinId)
    {
      FlavorTreat joinEntry = _db.FlavorTreat.FirstOrDefault(entry => entry.FlavorTreatId == joinId);
      _db.FlavorTreat.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = joinEntry.FlavorId });
    }
  }
}