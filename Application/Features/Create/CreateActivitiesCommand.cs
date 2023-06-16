using Domain;
using MediatR;

namespace Application.Features.Create
{
    public class CreateActivitiesCommand:IRequest
    {
        public Activity Activity { get; set; }
    }
}
