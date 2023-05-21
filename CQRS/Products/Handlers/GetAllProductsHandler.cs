using CleanWebAPI.CQRS.Products.Notifications;
using CleanWebAPI.CQRS.Products.Requests;
using CleanWebAPI.Models.MainModels;
using CleanWebAPI.Repositories.Interfaces;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using System.Runtime.CompilerServices;

namespace CleanWebAPI.CQRS.Products.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;
        private readonly IMemoryCache _memoryCache;
        public GetAllProductsHandler(IProductRepository productRepository, IMemoryCache memoryCache, IMediator mediator)
        {
            _productRepository = productRepository;
            _memoryCache = memoryCache;
            _mediator = mediator;
        }
        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            List<Product>? products = new();
            if (_memoryCache.TryGetValue("ProductList", out List<Product>? Products))
            {
                products = Products;
            }
            else
            {
                products = await _productRepository.GetProductListAsync();
                ProductsLoadedNotification productsLoaded = new ProductsLoadedNotification()
                {
                    Products = products,
                };

                await _mediator.Publish(productsLoaded);
            }
            return products;
        }
    }
}
