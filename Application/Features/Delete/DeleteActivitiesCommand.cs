using MediatR;
using System;


namespace Application.Features.Delete
{
    public class DeleteActivitiesCommand:IRequest
    {
        public Guid Id { get; set; }
    }
}
