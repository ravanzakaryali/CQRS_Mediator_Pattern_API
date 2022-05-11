using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Response
{
    public class CreateBlogCommandResponse
    {
        public bool IsSuccess { get; set; }
        public int Id { get; set; }
        public string UserId { get; set; }
    }
}
