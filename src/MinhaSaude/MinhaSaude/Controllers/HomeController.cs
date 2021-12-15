using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaSaude.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaSaude.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ////Fetch all files in the Folder (Directory).
            //string[] filePaths = Directory.GetFiles(Path.Combine(this.Environment.WebRootPath, "receitas/"));

            ////Copy File names to Model collection.
            //List<FileModel> files = new List<FileModel>();
            //foreach (string filePath in filePaths)
            //{
            //    files.Add(new FileModel { FileName = Path.GetFileName(filePath) });
            //}

            return View();
        }
        //public FileResult DownloadFile(string fileName)
        //{
        //    //Build the File Path.
        //    string path = Path.Combine(this.Environment.WebRootPath, "receitas/") + fileName;

        //    //Read the File data into Byte Array.
        //    byte[] bytes = System.IO.File.ReadAllBytes(path);

        //    //Send the File to Download.
        //    return File(bytes, "application/octet-stream", fileName);
        //}

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PerfilPaciente()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
