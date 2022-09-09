using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_MVC.Models;
using ProyectoFinal_MVC.Services;

namespace ProyectoFinal_MVC.Controllers
{
    public class EmpresaConstructoraController : Controller
    {
        private readonly EmpresaConstructoraServices empresaConstructoraServices;
        public EmpresaConstructoraController(EmpresaConstructoraServices empresaConstructoraServices)
        {
            this.empresaConstructoraServices = empresaConstructoraServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var empresaConstructora = await empresaConstructoraServices.GetAllEmpresaConstructora();
            return View(empresaConstructora);
        }
        [HttpPost]
        public async Task<IActionResult> Crear(string name, string direccion, string tipo)
        {
            var empresaConstructora = EmpresaConstructora.Build(Guid.NewGuid(), name, direccion, tipo);
            await this.empresaConstructoraServices.Crear(empresaConstructora);
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
            var empresaConstructora = await empresaConstructoraServices.Getobj(id);
            return View(empresaConstructora);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Guid id, string name, string direccion, string tipo)
        {
            if (ModelState.IsValid)
            {
                var empresaConstructora = EmpresaConstructora.Build(id, name, direccion, tipo);
                await this.empresaConstructoraServices.Update(empresaConstructora);
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
            var empresaConstructora = await empresaConstructoraServices.Getobj(id);
            await this.empresaConstructoraServices.Delete(empresaConstructora);
            return Content("1");
        }
    }
}
