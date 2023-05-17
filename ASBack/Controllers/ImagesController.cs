using BussinesLogic.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpPost]
        public IActionResult SaveCompressed([FromBody]string base64String)
        {
            try
            {
                var name = ImageWorker.SaveImage(base64String);
                return Ok($"Image saved under name {name}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
