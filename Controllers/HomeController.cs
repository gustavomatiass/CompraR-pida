using CompraRápida.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompraRápida.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult OpCadastro()
        {
            return View();
        }
        public IActionResult VenderProduto()
        {
            return View();
        }
        public IActionResult FazerLogin()
        {
            return View();
        }
        public IActionResult SouCliente()
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