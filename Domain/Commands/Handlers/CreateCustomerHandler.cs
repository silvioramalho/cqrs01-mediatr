using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Cqrs01.Domain.Commands.Requests;
using Cqrs01.Domain.Commands.Responses;

namespace Cqrs01.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            // Verifica se o cliente já está cadastrado
            //Valida os dados
            // Insere cliente
            // Envia email de boas vindas

            return new CreateCustomerResponse() {
                Id = Guid.NewGuid(),
                Name = "Cliente 01",
                Email = "cliente01@email.com",
                Date = DateTime.Now
            };
        }

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Insere cliente
            // Envia email de boas vindas

            var result = new CreateCustomerResponse() {
                Id = Guid.NewGuid(),
                Name = "Cliente 01",
                Email = "cliente01@email.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}