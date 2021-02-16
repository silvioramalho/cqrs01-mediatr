using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Cqrs01.Domain.Commands.Requests;
using Cqrs01.Domain.Commands.Responses;
using Cqrs01.Domain.Commands.Handlers;

namespace Cqrs01.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase 
    {
        
        [HttpPost]
        [Route("")]
        /*
        public CreateCustomerResponse Create(
            [FromServices]ICreateCustomerHandler handler,
            [FromBody]CreateCustomerRequest command)
            {
                return handler.Handle(command);
            }
        */
        public Task<CreateCustomerResponse> Create(
            [FromServices]IMediator mediator,
            [FromBody]CreateCustomerRequest command)
            {
                return mediator.Send(command);
            }

    }
}