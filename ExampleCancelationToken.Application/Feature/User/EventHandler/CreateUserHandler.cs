
using ExampleCancelationToken.Application.Feature.User.Commands;
using ExampleCancelationToken.Domain.Repositories;
using MediatR;

namespace ExampleCancelationToken.Application.Feature.User.EventHandler
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserHandler(IUserRepository userRepository) 
        { 
            _userRepository = userRepository;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.Entities.User
            {
                Name = request.Name,
                LastName = request.LastName,
                Phone = request.Phone,
                CreateOn = DateTime.Now,
                UpdateOn = DateTime.Now,
            };

            await _userRepository.AddAsync(user,cancellationToken);
            return user.Id;
        }
    }
}
