using Application.Queries.Request;
using Application.Queries.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.QueryHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQueryRequest, GetBlogQueryResponse>
    {
        private readonly AppDbContext _context;

        public GetBlogQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<GetBlogQueryResponse> Handle(GetBlogQueryRequest request, CancellationToken cancellationToken)
        {
            return await _context.Blogs.Where(b => b.Id == request.Id).Select(blog => new GetBlogQueryResponse
            {
                Id = blog.Id,
                Title = blog.Title,
                Content = blog.Content,
                CreatedDate = blog.CreatedDate,
                IsModified = blog.IsModified,
                UserId = blog.UserId,
            }).FirstOrDefaultAsync();
        }
    }
}
