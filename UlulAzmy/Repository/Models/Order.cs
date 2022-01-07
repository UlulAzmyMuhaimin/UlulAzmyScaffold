using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UlulAzmy.Repository.Models
{
    [Keyless]
    [Table("orders")]
    public partial class Order
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("created_at")]
        [StringLength(50)]
        public string CreatedAt { get; set; }
    }
}
