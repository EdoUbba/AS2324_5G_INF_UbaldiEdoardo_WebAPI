using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_UbaldiEdoardo_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        string status_result = "KO";

        [HttpGet("multiplointero")]
        public JsonResult multiplointero(int num, int factor)
        {
            
            return new JsonResult(
                new
                {
                    status_result,
                    res = (num % factor) == 0,
                });
        }

        [HttpGet("potenza")]
        public JsonResult potenza(int b, int esponente)
        {
            int res = 1;
            for(int i = 0; i < esponente; i++)
            {
                res *= b;
            }

            return new JsonResult(
                new
                {
                    status_result = "OK",
                    res
                });
        }

        
    }
}
