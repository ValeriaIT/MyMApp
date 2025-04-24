using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController(AppDbContext context) : BasicApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Topic>>> GetTopics()
        {
            return await context.Topics.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Topic>> GetTopicDetail(string id)
        {
            var topic = await context.Topics.FindAsync(id);
            if (topic == null)
            {
                return NotFound();
            }
            return topic;
        }
    }
}
