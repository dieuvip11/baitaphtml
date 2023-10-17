using Microsoft.AspNetCore.Mvc;
namespace demoMvc.Controllers;
using demomvc.Models;
public class giaiptbac2Controller : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Solve(DIEU2K2 Dieu)
    {
        if (Dieu.A == 0)
        {
            ViewBag.D = "A phai khac 0.";
            return View("Index", Dieu);
        }

        Dieu.Delta = Dieu.B * Dieu.B - 4 * Dieu.A * Dieu.C;
        ViewBag.A = "delta= " + Dieu.Delta;
        if (Dieu.Delta < 0)
        {
            ViewBag.B = "Phuong trinh khong vo nghiem.";
        }
        else if (Dieu.Delta == 0)
        {
            Dieu.X1 = -Dieu.B / (2 * Dieu.A);
            ViewBag.C = "Phuong trinh co nghiem kep: X1=X2=" + Dieu.X1;
        }
        else
        {
            Dieu.X1 = (-Dieu.B + Math.Sqrt(Dieu.Delta)) / (2 * Dieu.A);
            Dieu.X2 = (-Dieu.B - Math.Sqrt(Dieu.Delta)) / (2 * Dieu.A);
            ViewBag.D = "Phuong trinh co 2 nghiem: " + " X1= " + Dieu.X1 + " ; " + "X2 = " + Dieu.X2;
        }


        return View("Index", Dieu);
    }
}