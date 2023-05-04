using CleanWebAPI.Models.MainModels;
using MediatR;

namespace CleanWebAPI.CQRS.Products.Notifications.Notifications
{
    public class ProductChangedNotification : INotification
    {
        public Product Product { get; set; }
    }
}
