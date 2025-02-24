using ExampleCancelationToken.Application.DTOs;
using MediatR;

namespace ExampleCancelationToken.Application.Feature.User.Querys
{
    public class GetAllUserQuery : IRequest<IEnumerable<UserDto>>
    {
    }
}
