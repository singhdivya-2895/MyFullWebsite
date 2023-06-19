using Data;
using MediatR;

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
