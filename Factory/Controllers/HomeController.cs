using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private FactoryContext _db;
    
    public HomeController(FactoryContext db)
    {
      _db = db;
    }
  }
}