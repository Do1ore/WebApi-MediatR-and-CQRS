
using CleanWebAPI.Models;
using CleanWebAPI.Models.Context;
using CleanWebAPI.Repositories.Interfaces;
using CleanWebAPI.Requests;
using MediatR;
using System.Runtime.CompilerServices;

namespace CleanWebAPI.CQRS.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductQuery, Product>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(CreateProductQuery request, CancellationToken cancellationToken)
        {
            await _repository.AddProduct(request.Product);

            return request.Product;
        }
    }
}
