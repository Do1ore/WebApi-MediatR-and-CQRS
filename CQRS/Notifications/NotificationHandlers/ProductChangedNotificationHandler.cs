using CleanWebAPI.CQRS.Notifications.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Runtime.CompilerServices;

namespace CleanWebAPI.CQRS.Notifications.NotificationHandlers
{
    public class ProductChangedNotificationHandler : INotificationHandler<ProductChangedNotification>
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ProductChangedNotification> _logger;

        public ProductChangedNotificationHandler(IMemoryCache memoryCache, ILogger<ProductChangedNotification> logger)
        {
            _memoryCache = memoryCache;
            _logger = logger;
        }

        public async Task Handle(ProductChangedNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Product: {notification.Product.ProductFullName} started caching");
            await Task.Run(() =>
            {
                _memoryCache.Set(notification.Product.Id, notification.Product, TimeSpan.FromMinutes(10));
            });
            _logger.LogInformation($"Product: {notification.Product.ProductFullName} cached");
        }
    }
}
