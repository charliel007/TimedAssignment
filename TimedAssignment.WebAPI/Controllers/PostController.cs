using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimedAssignment.Models.Post;
using TimedAssignment.Services.Post;

namespace TimedAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _service;
        public PostController(IPostService service)
        {
            _service = service;
        }

    [HttpPost("Create")]
    public async Task<IActionResult> CreatePost([FromBody] PostCreate model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createResult = await _service.CreatePostAsync(model);
        if (createResult)
        {
            return Ok("Post was created");
        }

        return BadRequest("Post could not be created");
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPostsAsync()
    {
        var posts = await _service.GetAllPostsAsync();
        return Ok(posts);
    }
}

}
