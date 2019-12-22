using ApiCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiCursos.Controllers
{
    public class CursosController : Controller
    {
        private ProjetoContext db = new ProjetoContext();
        // GET: Cursos
        public ActionResult Index()
        {
            return View();
        }
    }
}