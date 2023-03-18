using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    [HttpGet("Add/{left}/{right}")]
    public int Get(int left, int right)
        => new Calculator().Sum(left, right);
}