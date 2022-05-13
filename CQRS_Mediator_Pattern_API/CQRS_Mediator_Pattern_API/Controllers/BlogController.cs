using Application.Commands.Request;
using Application.Commands.Response;
using Application.Queries.Request;
using Application.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS_Mediator_Pattern_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            GetAllBlogQueryRequest requestModel = new GetAllBlogQueryRequest();
            List<GetAllBlogQueryResponse> reposne = await _mediator.Send(requestModel);  
            return Ok(reposne);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            GetBlogQueryRequest request = new GetBlogQueryRequest { Id = id };
            GetBlogQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetUserId(string userId)
        {
            GetAllUserBlogQueryRequest request = new GetAllUserBlogQueryRequest { UserId = userId};
            List<GetAllUserBlogQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBlogCommandRequest requestModel)
        {
            CreateBlogCommandResponse response = (CreateBlogCommandResponse)await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
