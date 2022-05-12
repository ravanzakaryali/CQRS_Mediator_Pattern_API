using Application.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Request
{
    public class GetAllUserBlogQueryRequest : IRequest<GetAllBlogQueryResponse>
    {
        public string UserId { get; set; }
    }
}
