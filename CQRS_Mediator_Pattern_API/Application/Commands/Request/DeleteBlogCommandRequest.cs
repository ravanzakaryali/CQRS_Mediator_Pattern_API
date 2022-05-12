using Application.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Request
{
    public class DeleteBlogCommandRequest : IRequest<DeleteBlogCommandResponse>
    {
        public int Id { get; set; }
    }
}
