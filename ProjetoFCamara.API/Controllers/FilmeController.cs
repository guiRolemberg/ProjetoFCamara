using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProjetoFCamara.API.Models;

namespace ProjetoFCamara.API.Controllers
{
    [RoutePrefix("api/filmes")]
    public class FilmeController : ApiController
    {
        private FilmeDB db = new FilmeDB();

        [Authorize]
        [Route("")]
        public IQueryable<FilmeModel> GetFilmes()
        {
            return db.Filmes;
        }

        // GET: api/Filme/5
        [ResponseType(typeof(FilmeModel))]
        public IHttpActionResult GetFilmeModel(int id)
        {
            FilmeModel filmeModel = db.Filmes.Find(id);
            if (filmeModel == null)
            {
                return NotFound();
            }

            return Ok(filmeModel);
        }

        // PUT: api/Filme/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFilmeModel(int id, FilmeModel filmeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != filmeModel.FilmeID)
            {
                return BadRequest();
            }

            db.Entry(filmeModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmeModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Filme
        [ResponseType(typeof(FilmeModel))]
        public IHttpActionResult PostFilmeModel(FilmeModel filmeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Filmes.Add(filmeModel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = filmeModel.FilmeID }, filmeModel);
        }

        // DELETE: api/Filme/5
        [ResponseType(typeof(FilmeModel))]
        public IHttpActionResult DeleteFilmeModel(int id)
        {
            FilmeModel filmeModel = db.Filmes.Find(id);
            if (filmeModel == null)
            {
                return NotFound();
            }

            db.Filmes.Remove(filmeModel);
            db.SaveChanges();

            return Ok(filmeModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FilmeModelExists(int id)
        {
            return db.Filmes.Count(e => e.FilmeID == id) > 0;
        }
    }
}