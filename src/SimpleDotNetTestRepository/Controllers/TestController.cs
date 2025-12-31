using Microsoft.AspNetCore.Mvc;

namespace SimpleDotNetTestRepository.Controllers
{
    public class SimpleClass
    {
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
    }
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public SimpleClass Get()
        {
            return new SimpleClass()
            {
                Prop1 = 123,
                Prop2 = 245
            };
        }
    }
}
