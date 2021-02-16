using MediatR;
using Cqrs01.Domain.Commands.Responses;

namespace Cqrs01.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        
        public string Email { get; set; }
    }
}