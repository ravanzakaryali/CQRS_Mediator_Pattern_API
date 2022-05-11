using Application.Queries.Request;
using Application.Queries.Response;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Handlers.QueryHandlers
{
    class GetBlogQueryHandler
    {
        private readonly AppDbContext _context;

        public GetBlogQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<GetBlogQueryResponse>> GetUserBlogs(GetBlogQueryRequest getAllUserBlog)
        {
            return await _context.Blogs.Where(b => b.Id == getAllUserBlog.Id).Select(blog => new GetBlogQueryResponse
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
