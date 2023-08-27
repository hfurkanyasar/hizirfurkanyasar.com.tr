using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.UI.Controllers
{
    public class DosyaController : Controller
    {
       

        public IActionResult Indir()
        {
            string dosyaAdi = "CV Hızır Furkan Yaşar.pdf"; // İndirilen dosyanın adını belirtin
            string dosyaYolu = @"C:\Users\Hızır Furkan\Documents\CV Hızır Furkan Yaşar.pdf"; // Dosya yolunu düzenleyin

            byte[] dosyaBytes = System.IO.File.ReadAllBytes(dosyaYolu);

            return File(dosyaBytes, "application/octet-stream", dosyaAdi);
        }
    }
}
