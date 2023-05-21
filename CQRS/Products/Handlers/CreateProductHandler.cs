using CleanWebAPI.CQRS.Products.Notifications;
using CleanWebAPI.CQRS.Products.Requests;
using CleanWebAPI.Exceptions;
using CleanWebAPI.Models.Context;
using CleanWebAPI.Models.MainModels;
using CleanWebAPI.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.CompilerServices;

namespace CleanWebAPI.CQRS.Products.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductQuery, Product>
    {
        private readonly IProductRepository _repository;
        private readonly IMediator _mediator;

        public CreateProductHandler(IProductRepository repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<Product> Handle(CreateProductQuery request, CancellationToken cancellationToken)
        {
            if (request.Product == null)
            {
                return null;
            }
            await _repository.AddProduct(request.Product);

            ProductUpdatedNotification productUpdatedNotification = new();
            await _mediator.Publish(productUpdatedNotification);
            return request.Product;
        }
    }
}
