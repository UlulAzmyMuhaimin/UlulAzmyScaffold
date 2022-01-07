using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UlulAzmy.Repository.Models
{
    [Keyless]
    [Table("order_items")]
    public partial class OrderItem
    {
        [Column("order_id")]
        public int? OrderId { get; set; }
        [Column("product_id")]
        public int? ProductId { get; set; }
        [Column("quantity")]
        public int? Quantity { get; set; }
    }
}
