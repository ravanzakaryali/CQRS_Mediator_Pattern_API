using Application.Commands.Request;
using Application.Commands.Response;
using Domain.Entities;
using Persistence.Data;
using System.Threading.Tasks;

namespace Application.Handlers.CommandHandlers
{
    public class CreateBlogCommandHandler
    {
        private readonly AppDbContext _context;

        public CreateBlogCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<CreateBlogCommandResponse> CreateBlog(CreateBlogCommandRequest createBlogRequest)
        {
           await _context.Blogs.AddAsync(new Blog
            {
                Content = createBlogRequest.Content,
                Title = createBlogRequest.Title,
                UserId = createBlogRequest.UserId,
            });
            return new CreateBlogCommandResponse
            {
                UserId = createBlogRequest.UserId,
                IsSuccess = true,
            };
        }
    }
}
