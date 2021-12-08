using KuzeyCodeFirst.Models.BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeCore.Model
{
    [Table("Katlar")]
    public class Kat : BaseEntity, IKey
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(30, ErrorMessage = "Ad alanı en fazla 30 karakter olmalı")]
        public string Ad { get; set; }

        [Required, StringLength(5)]
        public string Kodu { get; set; }

        [Required]
        public int SiraNo { get; set; }

        [Required]
        public int MasaSayisi { get; set; }
        public ICollection<Masa> Masalar { get; set; } = new HashSet<Masa>();
    }
}
