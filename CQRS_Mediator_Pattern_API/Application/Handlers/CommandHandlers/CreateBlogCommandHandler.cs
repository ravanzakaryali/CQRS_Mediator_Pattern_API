using Application.Commands.Request;
using Application.Commands.Response;
using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Handlers.CommandHandlers
{
    public class CreateBlogCommandHandler
    {
        private readonly AppDbContext _context;

        public CreateBlogCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public CreateBlogCommandResponse CreateBlog(CreateBlogCommandRequest createBlogRequest)
        {
            _context.Blogs.Add(new Blog
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
