using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UlulAzmy.Repository.Models
{
    [Keyless]
    [Table("countries")]
    public partial class Country
    {
        [Column("code")]
        public int? Code { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("continent_name")]
        [StringLength(50)]
        public string ContinentName { get; set; }
    }
}
