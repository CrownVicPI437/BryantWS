using Microsoft.AspNetCore.Mvc;
using ShowMeRepair.api.Interfaces;
using ViewModelClass;

namespace ShowMeRepair.api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ShowMeRepairController : ControllerBase
{
    private readonly IShowMeRepairRepo _repo;

    public ShowMeRepairController(IShowMeRepairRepo repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> GetCradConents([FromBody] CardComponentVM cardComponentVm)
    {
        try
        {
            var result = await _repo.GetCardComponentContents(cardComponentVm);
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}