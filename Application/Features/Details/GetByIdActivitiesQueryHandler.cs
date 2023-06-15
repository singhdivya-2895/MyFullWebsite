using Data;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Details
{
    internal class GetByIdActivitiesQueryHandler : IRequestHandler<GetByIdActivitiesQuery, Activity>
    {
        private readonly DataContext _context;

        public GetByIdActivitiesQueryHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Activity> Handle(GetByIdActivitiesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Activities.FindAsync(request.ID);
        }
    }
}
