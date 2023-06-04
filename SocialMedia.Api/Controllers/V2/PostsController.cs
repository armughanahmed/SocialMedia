namespace SocialMedia.Api.Controllers.V2
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using SocialMedia.Domain.Models;

    /// <summary>
    /// Controller Responsible For Posts Domain
    /// </summary>
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        /// <summary>
        /// Fetches Post By Unique Id
        /// </summary>
        /// <param name="id">Post's Unique Id</param>
        /// <returns>Post<see cref="Post"/></returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var post = new Post
            {
                Id = id,
                Text = "Hello V2!",
            };

            return Ok(post);
        }
    }
}
