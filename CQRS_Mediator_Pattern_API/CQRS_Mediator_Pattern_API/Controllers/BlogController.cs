using Application.Commands.Request;
using Application.Commands.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBlogCommandRequest requestModel)
        {
            CreateBlogCommandResponse response = (CreateBlogCommandResponse)await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
