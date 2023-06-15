using Domain;
using MediatR;
using System;

namespace Application.Features.Details
{
    public class GetByIdActivitiesQuery:IRequest<Activity>
    {
        public Guid ID { get; set; }
    }
}
