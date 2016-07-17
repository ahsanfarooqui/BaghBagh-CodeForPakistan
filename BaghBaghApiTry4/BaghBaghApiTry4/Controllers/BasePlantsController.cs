using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BaghBaghApiTry4.Models;

namespace BaghBaghApiTry4.Controllers
{
    public class BasePlantsController : ApiController
    {
        private BaghBaghApiTry4Context db = new BaghBaghApiTry4Context();

        // GET: api/BasePlants
        public IQueryable<BasePlant> GetBasePlants()
        {
            return db.BasePlants;
        }

        // GET: api/BasePlants/5
        [ResponseType(typeof(BasePlant))]
        public async Task<IHttpActionResult> GetBasePlant(int id)
        {
            BasePlant basePlant = await db.BasePlants.FindAsync(id);
            if (basePlant == null)
            {
                return NotFound();
            }

            return Ok(basePlant);
        }

        // PUT: api/BasePlants/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBasePlant(int id, BasePlant basePlant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != basePlant.Id)
            {
                return BadRequest();
            }

            db.Entry(basePlant).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasePlantExists(id))
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

        // POST: api/BasePlants
        [ResponseType(typeof(BasePlant))]
        public async Task<IHttpActionResult> PostBasePlant(BasePlant basePlant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BasePlants.Add(basePlant);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = basePlant.Id }, basePlant);
        }

        // DELETE: api/BasePlants/5
        [ResponseType(typeof(BasePlant))]
        public async Task<IHttpActionResult> DeleteBasePlant(int id)
        {
            BasePlant basePlant = await db.BasePlants.FindAsync(id);
            if (basePlant == null)
            {
                return NotFound();
            }

            db.BasePlants.Remove(basePlant);
            await db.SaveChangesAsync();

            return Ok(basePlant);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BasePlantExists(int id)
        {
            return db.BasePlants.Count(e => e.Id == id) > 0;
        }
    }
}