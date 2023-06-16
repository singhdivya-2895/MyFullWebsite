using AutoMapper;
using Data;
using MediatR;

namespace Application.Features.Edit
{
    public class UpdateActivitiesCommandHandler : IRequestHandler<UpdateActivitiesCommand>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateActivitiesCommandHandler(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateActivitiesCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);
            _mapper.Map(request.Activity, activity);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
