using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Events
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Event Event { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            public DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var events = await _context.Events.FindAsync(request.Event.Id);

                _mapper.Map(request.Event, events);

                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }

    }
}