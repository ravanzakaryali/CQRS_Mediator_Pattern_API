using Application.Commands.Request;
using Application.Commands.Response;
using Domain.Entities;
using MediatR;
using Persistence.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.CommandHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommandRequest,CreateBlogCommandResponse>
    {
        private readonly AppDbContext _context;

        public CreateBlogCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<CreateBlogCommandResponse> Handle(CreateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var blog = await _context.Blogs.AddAsync(new Blog
            {
                Content = request.Content,
                Title = request.Title,
                UserId = request.UserId,
            });
            await _context.SaveChangesAsync();
            return new CreateBlogCommandResponse
            {
                UserId = request.UserId,
                IsSuccess = true,
                Id = blog.Entity.Id,
            };
        }
    }
}
