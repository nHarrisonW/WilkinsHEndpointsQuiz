using Microsoft.AspNetCore.Mvc;

namespace HelloAPi.Controllers;

[ApiController]
[Route("[controller]")]
public class inputController : ControllerBase
{
    [HttpGet]
    [Route ("UserInput/{inputFood}")]
    public string UserInput(string inputFood)
    {
        return $"You had {inputFood} for dinner!";
    }

    [HttpGet]
    [Route ("Multiply/{inputOne}/{inputTwo}")]
     public int Multiple(string inputOne, string inputTwo)
    {
        int numberOne = Convert.ToInt32(inputOne);
        int numberTwo = Convert.ToInt32(inputTwo);

        return numberOne * numberTwo;
    }
    
}