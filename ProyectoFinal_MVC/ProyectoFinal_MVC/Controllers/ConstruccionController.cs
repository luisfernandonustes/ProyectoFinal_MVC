using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_MVC.Models;
using ProyectoFinal_MVC.Services;

namespace ProyectoFinal_MVC.Controllers
{
    public class ConstruccionController : Controller
    {
        private readonly ConstruccionServices construccionServices;
        public ConstruccionController(ConstruccionServices construccionServices)
        {
            this.construccionServices = construccionServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var construccion = await construccionServices.GetAllConstruccion();
            return View(construccion);
        }
        [HttpPost]
        public async Task<IActionResult> Crear(string name, string lugarDeConstruccion, string tipo, DateTime fechaInicio,
            DateTime fechaFinal, Guid empresaConstructoraId)
        {
            var construccion = Construccion.Build(Guid.NewGuid(), name, lugarDeConstruccion, tipo, fechaInicio, fechaFinal, empresaConstructoraId);
            await this.construccionServices.Crear(construccion);
            return View();
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var trabajador = await construccionServices.Getobj(id);
            return View(trabajador);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Guid id, string name, string lugarDeConstruccion, string tipo, DateTime fechaInicio,
            DateTime fechaFinal, Guid empresaConstructoraId)
        {
            if (ModelState.IsValid)
            {
                var construccion = Construccion.Build( id, name, lugarDeConstruccion, tipo, fechaInicio, fechaFinal, empresaConstructoraId);
                await this.construccionServices.Update(construccion);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var construccion = await construccionServices.Getobj(id);
            await this.construccionServices.Delete(construccion);
            return Content("1");
        }
    }
}
