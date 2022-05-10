using BlogSite.Core.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [NonAction] // NonAction keyword'ü CreateActionResult methodunun bir endpoint olmadığını belirtiyor. Eğer bunu kullanmasaydık. Swagger'da hata alabilirdik.
        public IActionResult CreateActionResult<T>(ServiceResponse<T> response) // Durum kodlarını yöneteceğimiz methodumuz. Parametre olarak CustomResponseDto'yu alıyor.
                                                                                // çünkü tek bir class üzerinden response yönetimini sağlayacaktık. 
        {
            if (response.Success) // Eğer durum kodu 204 (nocontent) ise 
            {
                return new ObjectResult(null) // Boş bir response döndürüyoruz.
                {
                    StatusCode = 200
                };

            }
            else
            {
                return new ObjectResult(response) // Eğer durum kodu 204 değilse response'u döndürüyoruz.
                {
                    StatusCode = 404
                };

            }
        }
    }
}
