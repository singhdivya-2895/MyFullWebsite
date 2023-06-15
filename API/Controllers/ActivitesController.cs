using Application.Features.Activities;
using Application.Features.Create;
using Application.Features.Details;
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
    } 
}
