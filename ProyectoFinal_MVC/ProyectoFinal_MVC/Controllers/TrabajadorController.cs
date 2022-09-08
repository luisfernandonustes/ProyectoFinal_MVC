using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_MVC.Models;
using ProyectoFinal_MVC.Services;

namespace ProyectoFinal_MVC.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly TrabajadorServices trabajadorServices;
        public TrabajadorController(TrabajadorServices trabajadorServices)
        {
            this.trabajadorServices = trabajadorServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var trabajador = await trabajadorServices.GetAllTrabajador();
            return View(trabajador);
        }
        [HttpPost]
        public async Task<IActionResult> Crear(string name, string documentoIdentidad, string profesion, string TipoDeTrabajador, DateTime fechaDeNacimiento, Guid empresaConstructoraId)
        {
            var trabajador = Trabajador.Build(Guid.NewGuid(), name, documentoIdentidad, profesion, TipoDeTrabajador, fechaDeNacimiento, empresaConstructoraId);
            await this.trabajadorServices.Crear(trabajador);
            return View();
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
    }
}
