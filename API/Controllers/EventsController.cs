using Application.Events;
using Domain;
using Microsoft.AspNetCore.Mvc;
using static Application.Events.Create;

namespace API.Controllers
{
    public class EventsController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Event>>> GetEvents()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(Event events)
        {
            return Ok(await Mediator.Send(new Create.Command { Event = events }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(Guid id, Event events)
        {
            events.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Event = events }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}