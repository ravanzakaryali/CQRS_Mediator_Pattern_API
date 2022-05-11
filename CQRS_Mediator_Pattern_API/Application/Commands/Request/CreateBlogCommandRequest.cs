using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Request
{
    public class CreateBlogCommandRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
    }
}
