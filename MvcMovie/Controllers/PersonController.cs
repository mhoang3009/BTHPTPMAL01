using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
public IActionResult Index(Person ps)
{
    string str0utput ="xin chào" + ps.PersonId +"-" + ps.FullName + "-" + ps.Address;
    ViewBag.infoPerson = str0utput;
    return View();
}
        // GET: /Person/Welcome/ 
    }
}
