using CleanWebAPI.Models;
using MediatR;

namespace CleanWebAPI.CQRS.Notifications.Notifications
{
    public class ProductChangedNotification : INotification
    {
        public Product Product { get; set; }
    }
}
