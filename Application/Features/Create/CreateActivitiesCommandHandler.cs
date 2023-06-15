using Data;
using MediatR;

namespace Application.Features.Create
{
    public class CreateActivitiesCommandHandler : IRequestHandler <CreateActivitiesCommand>
    {
        private readonly DataContext _context;

        public CreateActivitiesCommandHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateActivitiesCommand request, CancellationToken cancellationToken)
        {
           _context.Activities.Add(request.Activity);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
