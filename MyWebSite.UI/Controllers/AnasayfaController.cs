using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.UI.Context;
using MyWebSite.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.UI.Controllers
{
    public class AnasayfaController : Controller
    {
        hfyContext _cnn;
        public AnasayfaController(hfyContext cnn )
        {
            _cnn = cnn;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult MesajGonder(Iletisim iletisim)
        {
            _cnn.Iletisim.Add(iletisim);
            _cnn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
