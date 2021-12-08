using KuzeyCodeFirst.Models.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeCore.Model
{
    [Table("Urunler")]
    public class Urun : BaseEntity, IKey
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50, ErrorMessage = "Ad alanı en fazla 50 karakter olmalı")]

        public string Ad { get; set; }
        [Required]
        public decimal Fiyat { get; set; }
        [Required]
        public int KategoriId { get; set; }
        [ForeignKey(nameof(KategoriId))]
        public Kategori Kategori { get; set; }
    }
}
