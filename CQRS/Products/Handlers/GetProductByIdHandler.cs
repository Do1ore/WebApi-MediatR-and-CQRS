using CleanWebAPI.CQRS.Products.Notifications.Notifications;
using CleanWebAPI.CQRS.Products.Requests;
using CleanWebAPI.Exceptions;
using CleanWebAPI.Models.MainModels;
using CleanWebAPI.Repositories.Interfaces;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace CleanWebAPI.CQRS.Products.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _repository;
        private readonly IMemoryCache _memoryCache;
        private readonly IMediator _mediator;
        public GetProductByIdHandler(IProductRepository repository, IMemoryCache memoryCache, IMediator mediator)
        {
            _repository = repository;
            _memoryCache = memoryCache;
            _mediator = mediator;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            Product? result = new();
            if (_memoryCache.TryGetValue(request.Id, out Product? product))
            {
                result = product;
            }
            else
            {
                result = await _repository.GetProductByIdAsync(request.Id);
                //Creating notification to cache product data

                if (result == null)
                {
                    throw new NotFoundException(nameof(Product), request.Id);
                }

                ProductChangedNotification productChanged = new()
                {
                    Product = result,
                };
                await _mediator.Publish(productChanged);
            }
            return result;
        }


    }
}


