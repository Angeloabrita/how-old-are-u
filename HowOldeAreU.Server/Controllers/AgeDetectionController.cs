using HowOldeAreU.Server.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HowOldeAreU.Server.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ValuesController : ControllerBase
    {

        public readonly IfaceServices _faces;
        public ValuesController(IfaceServices faces)
        {
            _faces = faces;
        }

        [HttpPost()]
        public async Task<IActionResult> UploadImage(IFormFile image)
        {
            if (image == null || image.Length == 0)
            {
                return BadRequest("Arquivo de imagem não fornecido.");
            }

            var path = image.FileName;

            var response = await _faces.FaceGet(path);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok("Imagem enviada com sucesso. " + response);

            }
            else
            {
                return StatusCode( (int)response.StatusCode, response.ErrorObject);
            }

        }
    }
}
