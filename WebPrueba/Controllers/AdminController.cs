using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace WebPrueba.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Ruta()
        {
            return View();
        }
        public IActionResult Notificacion()
        {
            return View();
        }
    }
}
