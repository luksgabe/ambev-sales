using Ambev.DeveloperEvaluation.Domain.SeedWork;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Users.Events
{
    public class UserRegisterEventHandler : IEventHandler<UserRegisterEvent>
    {

        private readonly IMapper _mapper;

        public UserRegisterEventHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task Handle(UserRegisterEvent @event, CancellationToken cancellationToken)
        {
            //Do something
        }
    }
}
