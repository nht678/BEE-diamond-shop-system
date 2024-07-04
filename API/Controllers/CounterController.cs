using AutoMapper;
using BusinessObjects.DTO.Counter;
using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CounterController(ICounterService service, IMapper mapper) : ControllerBase
{
    private ICounterService Service { get; } = service;
    private IMapper Mapper { get; } = mapper;

    [HttpGet("GetCounters")]
    public async Task<IActionResult> Get()
    {
        var counters = await Service.Gets();
        return Ok(counters);
    }
    [HttpGet("GetJewelryById/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var counter = await Service.GetById(id);
        return Ok(counter);
    }
    [HttpPost("CreateCounter")]
    public async Task<IActionResult> CreateCounter(CounterDTO counter)
    {
        var result = await Service.Create(Mapper.Map<Counter>(counter));
        return Ok(result);
    }
    [HttpPut("UpdateCounter/{id}")]
    public async Task<IActionResult> UpdateCounter(int id, CounterDTO counter)
    {
        var result = await Service.Update(id, Mapper.Map<Counter>(counter));
        return Ok(result);
    }
}