using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Events
{
    public class List
    {
        public class Query : IRequest<List<Event>> { };
        public class Handler : IRequestHandler<Query, List<Event>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Event>> Handle(Query request, CancellationToken cancellationToken)
            {

                return await _context.Events.ToListAsync();
            }
        }
    }
}