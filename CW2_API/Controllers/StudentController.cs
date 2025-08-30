using Microsoft.AspNetCore.Mvc;

namespace CW2_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return ["One", "Two", "Three"];
        }

        [HttpPatch]
        public IEnumerable<String> Patch()
        {
            return ["One", "Two", "Three"];
        }

        [HttpPut]
        public IEnumerable<String> Put()
        {
            return ["One", "Two", "Three"];
        }

        [HttpDelete]
        public IEnumerable<String> Delete()
        {
            return ["One", "Two", "Three"];
        }

        [HttpPost]
        public IEnumerable<String> Post()
        {
            return ["One", "Two", "Three"];
        }
    }
}
