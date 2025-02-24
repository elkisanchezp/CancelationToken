using ExampleCancelationToken.Application.Feature.User.Commands;
using ExampleCancelationToken.Application.Feature.User.Querys;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExampleController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser([FromQuery]CreateUserCommand commmand)
        {
            var result = await _mediator.Send(commmand, HttpContext.RequestAborted);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllUser")]
        public async Task<IActionResult> GetAllUser()
        {
            var result = await _mediator.Send(new GetAllUserQuery(), HttpContext.RequestAborted);
            return Ok(result);
        }
    }
}
