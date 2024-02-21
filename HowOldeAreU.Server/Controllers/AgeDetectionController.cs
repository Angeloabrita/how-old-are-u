using Microsoft.AspNetCore.Mvc;

namespace HowOldeAreU.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpPost()]
        public async Task<IActionResult> UploadImage(IFormFile image)
        {
            if (image == null || image.Length == 0)
            {
                return BadRequest("Arquivo de imagem não fornecido.");
            }

            var path = image.FileName;

           

            return Ok("Imagem enviada com sucesso. " + path);
        }
    }
}
