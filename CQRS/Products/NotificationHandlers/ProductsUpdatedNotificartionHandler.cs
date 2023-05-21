using MediatR;
using CleanWebAPI.CQRS.Products.Notifications.Notifications;
using Microsoft.Extensions.Caching.Memory;

namespace CleanWebAPI.CQRS.Products.Notifications.NotificationHandlers
{
    public class ProductsUpdatedNotificartionHandler : INotificationHandler<ProductUpdatedNotification>
    {

        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ProductsUpdatedNotificartionHandler> _logger;

        public ProductsUpdatedNotificartionHandler(IMemoryCache memoryCache, ILogger<ProductsUpdatedNotificartionHandler> logger)
        {
            _memoryCache = memoryCache;
            _logger = logger;
        }
        public async Task Handle(ProductUpdatedNotification notification, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                if (_memoryCache.TryGetValue("ProductList", out _))
                {
                    _memoryCache.Remove("ProductList");
                    _logger.LogInformation("Product's list changed. Cached data erased");
                }
            });
        }
    }
}