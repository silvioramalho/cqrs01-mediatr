using Cqrs01.Domain.Commands.Requests;
using Cqrs01.Domain.Commands.Responses;

namespace Cqrs01.Domain.Commands.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);        
    }
}