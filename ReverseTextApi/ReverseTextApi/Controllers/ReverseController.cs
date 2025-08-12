using Microsoft.AspNetCore.Mvc;
using ReverseTextApi.Model;
using ReverseTextApi.Service;

namespace ReverseTextApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseController : Controller
    {
        [HttpPost]
        public IActionResult Reverse(ReverseRequest request)
        {
            var reversed = ReverseService.ReverseString(request.Text);

            return Ok(new ReverseResponse { ReversedText = reversed });
        }
    }
}
