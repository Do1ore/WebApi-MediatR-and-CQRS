﻿using CleanWebAPI.CQRS.Products.Requests;
using CleanWebAPI.Exceptions;
using CleanWebAPI.Models.Context;
using CleanWebAPI.Models.MainModels;
using CleanWebAPI.Repositories.Interfaces;
using MediatR;
using System.Runtime.CompilerServices;

namespace CleanWebAPI.CQRS.Products.Handlers
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
            if (request.Product == null)
            {
                throw new BadRequestException(nameof(request.Product));
            }
            await _repository.AddProduct(request.Product);

            return request.Product;
        }
    }
}
