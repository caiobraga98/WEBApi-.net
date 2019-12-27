using ApiCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiCursos.Controllers
{
    public class CursosController : Controller
    {
        private ProjetoContext db = new ProjetoContext();
        // GET: Cursos
         public IHttpActionResult PostCurso(Curso curso)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
 
            db.Cursos.Add(curso);
            db.SaveChanges();
 
            return CreatedAtRoute("DefaultApi", new { id = curso.Id }, curso);
        }
 
        public IHttpActionResult GetCurso(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um numero maior que zero.");
 
            var curso = db.Cursos.Find(id);
 
            if (curso == null)
                return NotFound();
 
            return Ok(curso);
        }
    }
}