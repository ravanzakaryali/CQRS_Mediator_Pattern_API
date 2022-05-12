using Application.Commands.Request;
using Application.Commands.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.CommandHandlers
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommandRequest, DeleteBlogCommandResponse>
    {
        private readonly AppDbContext _context;

        public DeleteBlogCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<DeleteBlogCommandResponse> Handle(DeleteBlogCommandRequest request, CancellationToken cancellationToken)
        {
            _context.Blogs.Remove(await _context.Blogs.FirstOrDefaultAsync(p => p.Id == request.Id));
            return new DeleteBlogCommandResponse
            {
                Id = request.Id,
                IsSuccess = true,
            };
        }
    }
}
