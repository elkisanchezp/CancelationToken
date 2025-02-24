using MediatR;

namespace ExampleCancelationToken.Application.Feature.User.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }
    }
}
