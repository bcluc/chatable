using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chatable
{
    [Route("api/[controller]")]
    [ApiController]
    public class Style : ControllerBase
    {
        public async Task<ActionResult> ChangeStyle([FromQuery] string style)
        {
            Response.Cookies.Append("style", style);
            return Redirect("/");
        }
    }
}
