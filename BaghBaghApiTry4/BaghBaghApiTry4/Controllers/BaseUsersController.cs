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
    public class BaseUsersController : ApiController
    {
        private BaghBaghApiTry4Context db = new BaghBaghApiTry4Context();

        // GET: api/BaseUsers
        public IQueryable<BaseUser> GetBaseUsers()
        {
            return db.BaseUsers;
        }

        // GET: api/BaseUsers/5
        [ResponseType(typeof(BaseUser))]
        public async Task<IHttpActionResult> GetBaseUser(int id)
        {
            BaseUser baseUser = await db.BaseUsers.FindAsync(id);
            if (baseUser == null)
            {
                return NotFound();
            }

            return Ok(baseUser);
        }

        // PUT: api/BaseUsers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBaseUser(int id, BaseUser baseUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != baseUser.Id)
            {
                return BadRequest();
            }

            db.Entry(baseUser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BaseUserExists(id))
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

        // POST: api/BaseUsers
        [ResponseType(typeof(BaseUser))]
        public async Task<IHttpActionResult> PostBaseUser(BaseUser baseUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BaseUsers.Add(baseUser);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = baseUser.Id }, baseUser);
        }

        // DELETE: api/BaseUsers/5
        [ResponseType(typeof(BaseUser))]
        public async Task<IHttpActionResult> DeleteBaseUser(int id)
        {
            BaseUser baseUser = await db.BaseUsers.FindAsync(id);
            if (baseUser == null)
            {
                return NotFound();
            }

            db.BaseUsers.Remove(baseUser);
            await db.SaveChangesAsync();

            return Ok(baseUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BaseUserExists(int id)
        {
            return db.BaseUsers.Count(e => e.Id == id) > 0;
        }
    }
}