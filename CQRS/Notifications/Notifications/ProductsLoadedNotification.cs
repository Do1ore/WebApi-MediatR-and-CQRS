using CleanWebAPI.Models;
using MediatR;

namespace CleanWebAPI.CQRS.Notifications.Notifications
{
    public class ProductsLoadedNotification : INotification
    {
        public List<Product> Products { get; set; }
    }
}
