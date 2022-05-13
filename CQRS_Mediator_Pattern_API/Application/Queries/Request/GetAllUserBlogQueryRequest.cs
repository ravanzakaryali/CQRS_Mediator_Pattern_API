using Application.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Request
{
    public class GetAllUserBlogQueryRequest : IRequest<List<GetAllUserBlogQueryResponse>>
    {
        public string UserId { get; set; }
    }
}
