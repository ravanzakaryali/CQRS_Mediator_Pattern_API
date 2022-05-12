using Application.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Request
{
    public class GetBlogQueryRequest : IRequest<GetBlogQueryResponse> 
    {
        public int  Id { get; set; }
    }
}
