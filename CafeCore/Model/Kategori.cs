using KuzeyCodeFirst.Models.BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeCore.Model
{
    [Table("Kategoriler")]
    public class Kategori : BaseEntity, IKey
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50, ErrorMessage = "Ad alanı en fazla 50 karakter olmalı")]
        public string Ad { get; set; }

        [Required]
        public int SiraNo { get; set; }

        public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
