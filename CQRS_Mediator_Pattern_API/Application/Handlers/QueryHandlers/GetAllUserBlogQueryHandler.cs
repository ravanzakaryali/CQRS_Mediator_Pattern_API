using Application.Queries.Request;
using Application.Queries.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.QueryHandlers
{
    public class GetAllUserBlogQueryHandler : IRequestHandler<GetAllUserBlogQueryRequest, List<GetAllUserBlogQueryResponse>>
    {
        private readonly AppDbContext _context;

        public GetAllUserBlogQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<GetAllUserBlogQueryResponse>> Handle(GetAllUserBlogQueryRequest request, CancellationToken cancellationToken)
        {
            return await _context.Blogs.Where(b => b.UserId == request.UserId).Select(blog => new GetAllUserBlogQueryResponse
            {
                Id = blog.Id,
                Title = blog.Title,
                Content = blog.Content,
                CreatedDate = blog.CreatedDate,
                IsModified = blog.IsModified,
                UserId = blog.UserId,
            }).ToListAsync();
        }
    }
}
