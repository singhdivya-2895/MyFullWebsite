using Application.Features.Activities;
using Application.Features.Create;
using Application.Features.Delete;
using Application.Features.Details;
using Application.Features.Edit;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public ActivitiesController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            var getQuery = new GetAllActivitiesQuery();
            return await _mediator.Send(getQuery);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivitiesById(Guid id)
        {
            return await _mediator.Send(new GetByIdActivitiesQuery { ID = id });
        }
        [HttpPost]
        public async Task<IActionResult> CreateActivities (Activity activity)
        {
            return Ok(await _mediator.Send(new CreateActivitiesCommand { Activity = activity }));    
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateActivities(Guid id ,Activity activity)
        {
            activity.Id = id;
            return Ok(await _mediator.Send(new UpdateActivitiesCommand { Activity = activity }));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivities(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteActivitiesCommand { Id = id }));
        }

    } 
}
