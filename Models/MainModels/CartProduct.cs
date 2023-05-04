using System;
using System.Collections.Generic;

namespace CleanWebAPI.Models.MainModels;

public partial class CartProduct
{
    public int CartId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int Id { get; set; }

    public int? ProductModelId { get; set; }

    public virtual Cart Cart { get; set; } = null!;

    public virtual Product? ProductModel { get; set; }
}
