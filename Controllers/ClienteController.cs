using CompraRápida.Models;
using CompraRápida.repositorio;
using Microsoft.AspNetCore.Mvc;


namespace CompraRápida.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult InserirCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InserirCliente(Cliente cliente)
        {
            _clienteService.InserirCliente(cliente);
            return RedirectToAction("Index", "Home"); // ou redirecione para outra página após a inserção
        }
    }
}