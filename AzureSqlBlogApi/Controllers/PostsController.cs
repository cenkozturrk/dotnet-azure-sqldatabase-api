using AzureSqlBlogApi.Data;
using AzureSqlBlogApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureSqlBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly BlogDbContext _context;

        public PostsController(BlogDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Post>> Get()
        {
            return await _context.Posts.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return Ok(post);

        }
    }
}
