using Microsoft.AspNetCore.Mvc;

namespace homework.Controllers
{
    [Route("api/sample")] // DO NO CHANGE THE URL - NE VALTOZTASD MEG AZ URLT
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Model.SampleData> GetItem([FromQuery] string input)
        {
            if (string.IsNullOrEmpty(input))
                return BadRequest();

            if (input == "no")
                return NotFound();

            return Ok(new Model.SampleData(123, input));
        }

        [HttpDelete]
        public ActionResult<Model.SampleData> DeleteItem([FromQuery] string input)
        {
            return Ok();
        }
    }
}
