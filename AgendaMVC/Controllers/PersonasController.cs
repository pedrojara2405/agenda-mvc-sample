using Agenda.Logic;
using Agenda.ViewModels;
using System.Web.Mvc;

namespace AgendaMVC.Controllers
{
    public class PersonasController : Controller
    {
        private LogicaPersonas _logicaPersonas;

        public PersonasController()
        {
            _logicaPersonas = new LogicaPersonas();
        }
        public ActionResult Detalles(int id)
        {
            Agenda.Entities.Persona entidadPersonas = _logicaPersonas.ObtienePersona(id);
            PersonaViewModel personaVm = new PersonaViewModel()
            {
                Id = entidadPersonas.Id,
                Nombre = entidadPersonas.Nombre,
                Numero = entidadPersonas.Numero
            };
            return View(personaVm);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(CreaPersonaViewModel personaNueva)
        {
            Agenda.Entities.Persona entidadPersona = new Agenda.Entities.Persona
            {
                Nombre = personaNueva.Nombre,
                Numero = personaNueva.Numero
            };
            _logicaPersonas.InsertaPersona(entidadPersona);
            return RedirectToAction("Detalles", new { id = entidadPersona.Id });
        }
    }
}