using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private FactoryContext _db;
    
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }
    
    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
        .Include(machine => machine.RepairLicenses)
        .ThenInclude(license => license.Machine)
        .FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

    public ActionResult AddEngineer(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int engineerId)
    {
      System.Console.WriteLine(machine.Name);
      if (engineerId != 0)
      {
        _db.RepairLicenses.Add(new RepairLicense() { EngineerId=engineerId, MachineId=machine.MachineId});
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id=machine.MachineId });
    }

    [HttpPost]
    public ActionResult RemoveEngineer(int machineId, int repairLicenseId)
    {
      RepairLicense thisRepairLicense = _db.RepairLicenses.FirstOrDefault(repairLicense => repairLicense.RepairLicenseId == repairLicenseId);
      _db.RepairLicenses.Remove(thisRepairLicense);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id=machineId });
    }
  }
}