using CafeCore.Model.Abstracts;
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

        [Required, StringLength(30, ErrorMessage = "Ad alanı en fazla 30 karakter olmalı")]
        public string Ad { get; set; }

        [Required]
        public int SiraNo { get; set; }

        public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
