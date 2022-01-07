using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UlulAzmy.Repository.Models
{
    [Keyless]
    [Table("products")]
    public partial class Product
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("merchant_id")]
        public int? MerchantId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("price")]
        public int? Price { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("created_at")]
        [StringLength(50)]
        public string CreatedAt { get; set; }
    }
}
