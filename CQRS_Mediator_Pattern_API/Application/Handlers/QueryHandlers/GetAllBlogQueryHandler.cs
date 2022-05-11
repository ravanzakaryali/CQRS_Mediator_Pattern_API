using Application.Queries.Request;
using Application.Queries.Response;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.QueryHandlers
{
    public class GetAllBlogQueryHandler
    {
        private readonly AppDbContext _context;

        public GetAllBlogQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async  Task<List<GetAllBlogQueryResponse>> GetAllProduct(GetAllBlogQueryRequest getAllBlog)
        {
            return await _context.Blogs.Select(blog => new GetAllBlogQueryResponse
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
