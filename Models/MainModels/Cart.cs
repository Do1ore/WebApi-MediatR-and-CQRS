using System;
using System.Collections.Generic;

namespace CleanWebAPI.Models.MainModels;

public partial class Cart
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<CartProduct> CartProducts { get; set; } = new List<CartProduct>();

    public virtual MyPetUser? User { get; set; }
}
