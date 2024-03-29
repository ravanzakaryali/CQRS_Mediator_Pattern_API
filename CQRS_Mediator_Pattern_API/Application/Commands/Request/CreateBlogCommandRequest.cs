﻿using Application.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Request
{
    public class CreateBlogCommandRequest : IRequest<CreateBlogCommandResponse>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
    }
}
