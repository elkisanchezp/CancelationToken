using ExampleCancelationToken.Application.DTOs;
using ExampleCancelationToken.Application.Feature.User.Querys;
using ExampleCancelationToken.Domain.Repositories;
using MediatR;

namespace ExampleCancelationToken.Application.Feature.User.EventHandler
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, IEnumerable<UserDto>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            try
            {
                //Heavy query
                var user = await _userRepository.GetAllUsersAsync(cancellationToken);

                return user.Select(x => new UserDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    LastName = x.LastName,
                    Phone = x.Phone,
                    CreateOn = x.CreateOn,
                    UpdateOn = x.UpdateOn
                });

            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("GetAllUserQueryHandler: Operación cancelada");
                return new List<UserDto>();
            }
        }
    }
}
