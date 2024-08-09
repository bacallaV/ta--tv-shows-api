using Microsoft.AspNetCore.Mvc;
using TvShows.Dtos;
using TvShows.Models;
using TvShows.Service;

namespace TvShows.Controller;

[ApiController]
[Route("api/[controller]")]
public class TvShowsController : ControllerBase
{
    private readonly ITvShowsService tvShowsService;

    public TvShowsController(ITvShowsService tvShowsService)
    {
        this.tvShowsService = tvShowsService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(tvShowsService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var tvs = tvShowsService.GetById(id);

        if (tvs == null) return NotFound();

        return Ok(tvs);
    }

    [HttpPost]
    public IActionResult Post([FromBody]TvShowDto tvShowDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var tvs = tvShowsService.Create(tvShowDto);

        return Ok(tvs);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]TvShowDto tvShowDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var tvs = tvShowsService.Update(id, tvShowDto);

        if (tvs == null) return NotFound();

        return Ok(tvs);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return tvShowsService.Delete(id) ? Ok() : NotFound();
    }
}