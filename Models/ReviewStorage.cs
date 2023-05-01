using System;
using System.Collections.Generic;

namespace CleanWebAPI.Models;

public partial class ReviewStorage
{
    public Guid ReviewStorageId { get; set; }

    public string? MyPetUserId { get; set; }

    public virtual MyPetUser? MyPetUser { get; set; }

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();
}
