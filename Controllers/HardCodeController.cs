using Microsoft.AspNetCore.Mvc;

namespace HelloAPi.Controllers;

[ApiController]
[Route("[controller]")]
public class HardCodeController : ControllerBase
{
    [HttpGet]
    [Route("DinnerTime")]
    public string ForDinner()
    {
        return "I had a deilicious piece of pizza for dinner last night!";
    }


    [HttpGet]
    [Route("MathTime")]
    public int MathSucks()
    {
        return 210 * 2;
    }
}
//Revised this and now the API's are working as expected,   work is not for credit i would still like to show that i understand the material