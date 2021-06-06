using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private FactoryContext _db;
    
    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }
    
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      if (String.IsNullOrWhiteSpace(engineer.Name) == false)
      {
        _db.Engineers.Add(engineer);
      }
      _db.SaveChanges();
      return RedirectToAction("Index");    
    }

    public ActionResult Details(int id)
    {
      Engineer thisEngineer = _db.Engineers
        .Include(engineer => engineer.RepairLicenses)
        .ThenInclude(license => license.Machine)
        .FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    public ActionResult AddMachine(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int machineId)
    {
      if (machineId != 0)
      {
        _db.RepairLicenses.Add(new RepairLicense() { EngineerId=engineer.EngineerId, MachineId=machineId});
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id=engineer.EngineerId });
    }

    [HttpPost]
    public ActionResult RemoveMachine(int engineerId, int repairLicenseId)
    {
      RepairLicense thisRepairLicense = _db.RepairLicenses.FirstOrDefault(repairLicense => repairLicense.RepairLicenseId == repairLicenseId);
      _db.RepairLicenses.Remove(thisRepairLicense);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id=engineerId });
    }

    public ActionResult Delete(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      if (id != 0)
      {
        _db.Engineers.Remove(thisEngineer);
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}