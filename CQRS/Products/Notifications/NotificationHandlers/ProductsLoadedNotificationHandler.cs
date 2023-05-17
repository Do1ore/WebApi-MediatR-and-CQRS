using CleanWebAPI.CQRS.Products.Notifications.Notifications;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace CleanWebAPI.CQRS.Products.Notifications.NotificationHandlers
{
    public class ProductsLoadedNotificationHandler : INotificationHandler<ProductsLoadedNotification>
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ProductsLoadedNotificationHandler> _logger;

        public ProductsLoadedNotificationHandler(IMemoryCache memoryCache, ILogger<ProductsLoadedNotificationHandler> logger)
        {
            _memoryCache = memoryCache;
            _logger = logger;
        }

        public async Task Handle(ProductsLoadedNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("The caching proccess started. Product's quantity: {0}", notification.Products.Count);
            await Task.Run(() =>
            {
                _memoryCache.Set("ProductList", notification.Products);

            });
            await Task.WhenAll();
            _logger.LogInformation("The caching proccess finished.");
        }
    }
}
