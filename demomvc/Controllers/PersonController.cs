using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
namespace demomvc.Controllers
{
    public class PersonController : Controller

    {
        public IActionResult Index(){
        return View();
    
        }
        [HttpPost]
        public IActionResult Index(Person ps){
            string str = "Hello "+ ps.PersonID+"-"+ps.fullname.ToUpper();
            ViewBag.D=str;
            return View();
    }



    }
    
}