using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UlulAzmy.Repository.Models
{
    [Keyless]
    [Table("users")]
    public partial class User
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("full_name")]
        [StringLength(50)]
        public string FullName { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("gender")]
        [StringLength(50)]
        public string Gender { get; set; }
        [Column("date_of_birth")]
        [StringLength(50)]
        public string DateOfBirth { get; set; }
        [Column("country_code")]
        public int? CountryCode { get; set; }
        [Column("created_at")]
        [StringLength(50)]
        public string CreatedAt { get; set; }
    }
}
