using Application.Commands.Request;
using Application.Commands.Response;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.CommandHandlers
{
    public class DeleteBlogCommandHandler
    {
        private readonly AppDbContext _context;

        public DeleteBlogCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<DeleteBlogCommandResponse> DeleteBlog(DeleteBlogCommandRequest deleteBlog)
        {
            _context.Blogs.Remove(await _context.Blogs.FirstOrDefaultAsync(p => p.Id == deleteBlog.Id));
            return new DeleteBlogCommandResponse
            {
                Id = deleteBlog.Id,
                IsSuccess = true,
            };
        }
    }
}
