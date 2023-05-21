using CleanWebAPI.Models.MainModels;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Notifications.Notifications
{
    public class ProductsLoadedNotification : INotification
    {
        public List<Product> Products { get; set; }
    }
}
