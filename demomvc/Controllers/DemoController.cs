using Microsoft.AspNetCore.Mvc;

namespace demomvc.Controllers;

    public class DemoController : Controller
    {
        // khai bao cac phuong thuc
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fName, string dieu)
        {
            string strResult = "Xin chao" + fName + "-" + dieu;
            ViewBag.xcv = strResult;
            return View();
    }
    
}