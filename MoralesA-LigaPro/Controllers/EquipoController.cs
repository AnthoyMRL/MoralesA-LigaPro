using Microsoft.AspNetCore.Mvc;
using MoralesA_LigaPro.Models;
using MoralesA_LigaPro.Repositories;

namespace MoralesA_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipo();

            return View(equipos);
        }

        public IActionResult Edit(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipos(Id);

            return View(equipo);
        }


    }


}
