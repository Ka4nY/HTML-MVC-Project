using Microsoft.AspNetCore.Mvc;
using NetCore8MVC.Models;



namespace NetCore8MVC.Controllers
{
    public class ArabaController : Controller
    {
      
        public ArabaController()
        {

        }

        public IActionResult Index()
        {
          
            TCar araba = new TCar(); 
            araba.Marka = "Ford"; 
            araba.Model = "Mustang";
            araba.ModelYil = 2008;
            araba.Renk = "Kırmızı";

            return View(TCar); 
        }
        
        public IActionResult Ekle()
        {
            return View();
        }z<
    }
}
