using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_UbaldiEdoardo_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplesController : ControllerBase
    {
        [HttpGet("Multiples")]
        public JsonResult Multiples(int num, int factor)
        {
            return new JsonResult(
                new
                {
                    res = (num % factor) == 0,
                });
        }
    }
}
