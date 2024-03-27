using ContestManagerDomain.Entities;
using ContestManagerService.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace ContestManagerWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Produces("application/json")]
public class ContestController : ControllerBase
{
    private readonly IContestService _contestService;

    public ContestController(IContestService contestService)
    {
        _contestService = contestService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IAsyncEnumerable<Contest>>> GetContests()
    {
        try
        {
            var contests = await _contestService.GetContests();
            return Ok(contests);
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error to get contests!");
        }
    }

    [HttpGet("ContestByName")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IAsyncEnumerable<Contest>>>
        GetContestsByName([FromQuery] string name)
    {
        try
        {
            var contests = await _contestService.GetContestsByName(name);
            if (!contests.Any())
                return NotFound($"Don't exist contests white name {name}");
            
            return Ok(contests);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet("{id:int}", Name="GetContest")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IAsyncEnumerable<Contest>>>GetContest(int id)
    {
        try
        {
            var contest = await _contestService.GetContest(id);
            if (contest == null)
                return NotFound($"Don't exist contest white id: {id}");

            return Ok(contest);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<ActionResult> Create(Contest contest)
    {
        try
        {
            await _contestService.CreateContest(contest);
            return CreatedAtRoute(nameof(GetContest), new {id = contest.Id}, contest );
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Edit(int id, [FromBody] Contest contest)
    {
        try
        {
            if (contest.Id == id)
            {
                await _contestService.UpdateContest(contest);
                return Ok($"Contest with id: {id} updated");
            }

            return BadRequest("Incorrect id");
        }
        catch
        {
            return BadRequest("Invalid request!");
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            var contest = await _contestService.GetContest(id);
            if (contest != null)
            {
                await _contestService.DeleteContest(contest);
                return Ok($"Contest id: {id} deleted");
            }

            return NotFound($"Contest id: {id} not found");
        }
        catch
        {
            return BadRequest("Invalid request!");
        }
    }
}

