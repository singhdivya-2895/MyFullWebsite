using Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Delete
{
    public class DeleteActivitiesCommandHandler : IRequestHandler<DeleteActivitiesCommand>
    {
        private readonly DataContext _context;

        public DeleteActivitiesCommandHandler(DataContext context) 
        {
            _context = context;
        } 
        public async Task<Unit> Handle(DeleteActivitiesCommand request, CancellationToken cancellationToken)
        {
            var activity =  await _context.Activities.FindAsync(request.Id);
                    _context.Remove(activity);
                  await _context.SaveChangesAsync();
                   return Unit.Value;
        }
    }
}
