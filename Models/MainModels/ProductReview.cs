using System;
using System.Collections.Generic;

namespace CleanWebAPI.Models.MainModels;

public partial class ProductReview
{
    public Guid ReviewStorageId { get; set; }

    public Guid ReviewId { get; set; }

    public int ProductId { get; set; }

    public int ReviewMark { get; set; }

    public string? ReviewText { get; set; }

    public DateTime PublishedAt { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual ReviewStorage ReviewStorage { get; set; } = null!;
}
