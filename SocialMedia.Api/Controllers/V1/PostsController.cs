namespace SocialMedia.Api.Controllers.V1
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller Responsible For Posts Domain
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        /// <summary>
        /// Fetches Post By Unique Id
        /// </summary>
        /// <param name="id">Post's Unique Id</param>
        /// <returns>V1</returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok("Hello V1");
        }
    }
}
