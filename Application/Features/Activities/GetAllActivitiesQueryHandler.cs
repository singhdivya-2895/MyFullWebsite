using Data;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Activities
{
    public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, 
                                                                      List<Activity>>
    {
        private readonly DataContext _context;
        public GetAllActivitiesQueryHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Activity>> Handle(GetAllActivitiesQuery request,
                                          CancellationToken cancellationToken)
        {
            return await _context.Activities.ToListAsync();
        }
    }
}
