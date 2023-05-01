using CleanWebAPI.Models;
using CleanWebAPI.Models.Context;
using CleanWebAPI.Repositories.Interfaces;
using CleanWebAPI.Requests;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanWebAPI.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductQuery, Product>
    {
        private readonly IProductRepository _repository;

        public UpdateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(UpdateProductQuery request, CancellationToken cancellationToken)
        {
            await _repository.UpdateProductAsync(request.Proudct);
            return request.Proudct;
        }
    }
}
