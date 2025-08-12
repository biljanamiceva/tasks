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
            string trimmedText = request.Text.Trim();
            if (string.IsNullOrEmpty(trimmedText))
            {
                return BadRequest(new { error = "Text cannot be empty." });
            }
            var reversed = ReverseService.ReverseString(trimmedText);

            return Ok(new ReverseResponse { ReversedText = reversed });
        }
    }
}
