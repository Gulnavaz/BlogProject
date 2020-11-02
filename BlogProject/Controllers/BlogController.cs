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
using BlogProject.DAL;
using BlogProject.Models;

namespace BlogProject.Controllers
{
    [Route("api/blog")]
    public class BlogController : ApiController
    {
        private BlogContext db = new BlogContext();

        // GET: api/Blog
        public IQueryable<BlogPost> GetBlogPosts()
        {
            return db.BlogPosts;
        }

        // GET: api/Blog/5
        [ResponseType(typeof(BlogPost))]
        public async Task<IHttpActionResult> GetBlogPost(int id)
        {
            BlogPost blogPost = await db.BlogPosts.FindAsync(id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return Ok(blogPost);
        }

        // PUT: api/Blog/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBlogPost(int id, BlogPost blogPost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != blogPost.ID)
            {
                return BadRequest();
            }

            db.Entry(blogPost).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogPostExists(id))
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

        // POST: api/Blog
        [ResponseType(typeof(BlogPost))]
        public async Task<IHttpActionResult> PostBlogPost(BlogPost blogPost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BlogPosts.Add(blogPost);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = blogPost.ID }, blogPost);
        }

        // DELETE: api/Blog/5
        [ResponseType(typeof(BlogPost))]
        public async Task<IHttpActionResult> DeleteBlogPost(int id)
        {
            BlogPost blogPost = await db.BlogPosts.FindAsync(id);
            if (blogPost == null)
            {
                return NotFound();
            }

            db.BlogPosts.Remove(blogPost);
            await db.SaveChangesAsync();

            return Ok(blogPost);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BlogPostExists(int id)
        {
            return db.BlogPosts.Count(e => e.ID == id) > 0;
        }
    }
}