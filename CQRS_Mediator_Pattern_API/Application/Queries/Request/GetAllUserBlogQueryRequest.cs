using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Request
{
    public class GetAllUserBlogQueryRequest : IRequest
    {
        public string UserId { get; set; }
    }
}
