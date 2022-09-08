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
    }
}
