using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IESMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace IESMvc.Controllers
{
    public class InstitucionController : Controller
    {

        private IList<Institucion> instituciones = new List<Institucion>
        {
            new Institucion { InstitucionID=1, Nombre="UniParana", Direccion="Parana"},
            new Institucion { InstitucionID=2, Nombre="UniSanta", Direccion="Santa Catarina"},
            new Institucion { InstitucionID=3, Nombre = "UniSãoPaulo", Direccion="São Paulo"},            new Institucion { InstitucionID=4, Nombre = "UniSulgrandense", Direccion="Rio Grande do Sul"},            new Institucion { InstitucionID=5, Nombre = "UniCarioca", Direccion="Rio de janeiro"}
        };

        public IActionResult Index()
        {
            return View(instituciones);
        }
    }
}
