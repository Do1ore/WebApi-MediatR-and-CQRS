using CleanWebAPI.CQRS.Products.Notifications.Notifications;
using CleanWebAPI.CQRS.Products.Requests;
using CleanWebAPI.Exceptions;
using CleanWebAPI.Models.MainModels;
using CleanWebAPI.Repositories.Interfaces;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductQuery, Product>
    {
        private readonly IProductRepository _repository;
        private readonly IMediator _mediator;

        public UpdateProductHandler(IProductRepository repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<Product> Handle(UpdateProductQuery request, CancellationToken cancellationToken)
        {
            if (request.Product == null || !_repository.IsExists(request.Product.Id))
            {
                return null;
            }
           
            await _repository.UpdateProductAsync(request.Product);

            ProductUpdatedNotification productUpdatedNotification = new();
            await _mediator.Publish(productUpdatedNotification);

            return request.Product;
        }
    }
}
