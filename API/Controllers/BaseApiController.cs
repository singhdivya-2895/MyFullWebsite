using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController: ControllerBase
    {
        protected IMediator _mediator;

        public BaseApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}