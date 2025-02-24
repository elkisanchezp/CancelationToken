using ExampleCancelationToken.Application.Feature.User.Querys;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {

        private IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {

            var modelo = await _mediator.Send(new GetAllUserQuery(), cancellationToken);

            return View(modelo);

        }
    }
}
