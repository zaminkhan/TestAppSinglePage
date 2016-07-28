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
using TestApp.DAL;

namespace TestApp.Controllers
{
    public class ImagesForTestsController : ApiController
    {
        private ImageDB db = new ImageDB();

        // GET: api/ImagesForTests
        public IQueryable<ImagesForTest> GetImagesForTests()
        {
            return db.ImagesForTests;
        }

        // GET: api/ImagesForTests/5
        [ResponseType(typeof(ImagesForTest))]
        public IHttpActionResult GetImagesForTest(int id)
        {
            ImagesForTest imagesForTest = db.ImagesForTests.Find(id);
            if (imagesForTest == null)
            {
                return NotFound();
            }

            return Ok(imagesForTest);
        }

        // PUT: api/ImagesForTests/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImagesForTest(int id, ImagesForTest imagesForTest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imagesForTest.Id)
            {
                return BadRequest();
            }

            db.Entry(imagesForTest).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagesForTestExists(id))
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

        // POST: api/ImagesForTests
        [ResponseType(typeof(ImagesForTest))]
        public IHttpActionResult PostImagesForTest(ImagesForTest imagesForTest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ImagesForTests.Add(imagesForTest);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = imagesForTest.Id }, imagesForTest);
        }

        // DELETE: api/ImagesForTests/5
        [ResponseType(typeof(ImagesForTest))]
        public IHttpActionResult DeleteImagesForTest(int id)
        {
            ImagesForTest imagesForTest = db.ImagesForTests.Find(id);
            if (imagesForTest == null)
            {
                return NotFound();
            }

            db.ImagesForTests.Remove(imagesForTest);
            db.SaveChanges();

            return Ok(imagesForTest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImagesForTestExists(int id)
        {
            return db.ImagesForTests.Count(e => e.Id == id) > 0;
        }
    }
}