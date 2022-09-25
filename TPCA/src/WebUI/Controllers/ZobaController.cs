using MediatR;
using Microsoft.AspNetCore.Mvc;
using TPCA.Application.TodoLists.Commands.CreateTodoList;
using TPCA.Application.TodoLists.Commands.UpdateTodoList;
using TPCA.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using TPCA.Application.Zobas.Commands.CreateZoba;
using TPCA.Application.Zobas.Commands.DeleteZoba;
using TPCA.Application.Zobas.Commands.UpdateZoba;
using TPCA.Application.Zobas.Queries.GetZobas;
using TPCA.Domain.Entities;

namespace TPCA.WebUI.Controllers;

public class ZobaController : ApiControllerBase
{
    [HttpGet]
    public async Task<ZobasVM> Get()
    {
        return await Mediator.Send(new GetZobaQuery());
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateZobaCommand command)
    {
        return await Mediator.Send(command);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<int>> Delete(int id)
    {
        await Mediator.Send(new DeleteZobaCommand(id));
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, UpdateZobaCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }
}

