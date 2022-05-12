using Application.Queries.Request;
using Application.Queries.Response;
using Domain.Entities;
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
    public class GetAllBlogQueryHandler : IRequestHandler<GetAllBlogQueryRequest, List<GetAllBlogQueryResponse>>
    {
        private readonly AppDbContext _context;

        public GetAllBlogQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<GetAllBlogQueryResponse>> GetAllProduct(GetAllBlogQueryRequest getAllBlog)
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

        public async Task<List<GetAllBlogQueryResponse>> Handle(GetAllBlogQueryRequest request, CancellationToken cancellationToken)
        {
            List<GetAllBlogQueryResponse> allBlog = new List<GetAllBlogQueryResponse>();
            List<Blog> blogDb = await _context.Blogs.ToListAsync();
            foreach (Blog blog in blogDb)
            {
                GetAllBlogQueryResponse newBlog = new GetAllBlogQueryResponse
                {
                    Content = blog.Content,
                    CreatedDate=blog.CreatedDate,
                    Id = blog.Id,
                    IsModified=blog.IsModified,
                    Title = blog.Title,
                    UserId = blog.UserId
                };
                allBlog.Add(newBlog);
            }
            return allBlog;
        }
    }
}
