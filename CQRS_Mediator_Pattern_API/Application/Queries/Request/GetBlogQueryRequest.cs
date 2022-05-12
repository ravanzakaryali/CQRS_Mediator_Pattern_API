using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Request
{
    public class GetBlogQueryRequest : GetBlogQueryResponse 
    {
        public int  Id { get; set; }
    }
}
