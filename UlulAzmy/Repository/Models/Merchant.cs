using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UlulAzmy.Repository.Models
{
    [Keyless]
    [Table("merchants")]
    public partial class Merchant
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("merchant_name")]
        [StringLength(50)]
        public string MerchantName { get; set; }
        [Column("admin_id")]
        public int? AdminId { get; set; }
        [Column("country_code")]
        public int? CountryCode { get; set; }
        [Column("created_at")]
        [StringLength(50)]
        public string CreatedAt { get; set; }
    }
}
