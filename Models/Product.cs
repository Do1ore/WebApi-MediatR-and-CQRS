﻿using System;
using System.Collections.Generic;

namespace CleanWebAPI.Models;

public partial class Product
{
    public int Id { get; set; }

    public int? Rating { get; set; }

    public double? DefaultPrice { get; set; }

    public double? MinPrice { get; set; }

    public double? MaxPrice { get; set; }

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public string? ProductFullName { get; set; }

    public string? ProductExtendedFullName { get; set; }

    public string? ProductType { get; set; }

    public string? MainFileName { get; set; }

    public string? MainFilePath { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? LastTimeEdited { get; set; }

    public string? ParsedUrl { get; set; }

    public virtual ICollection<CartProduct> CartProducts { get; set; } = new List<CartProduct>();

    public virtual ICollection<ExtraImage> ExtraImages { get; set; } = new List<ExtraImage>();

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();
}
