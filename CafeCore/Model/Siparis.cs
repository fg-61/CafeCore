using KuzeyCodeFirst.Models.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeCore.Model
{
    [Table("Siparisler")]
    public class Siparis : BaseEntity, IKey
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Adet { get; set; }

        public int Fiyat { get; set; }
        [NotMapped]
        public decimal AraToplam { get => Adet * Fiyat;}
        [Required]
        public int MasaId { get; set; }
        [ForeignKey(nameof(MasaId))]
        public Masa Masa { get; set; }

        [Required]
        public int UrunId { get; set; }
        [ForeignKey(nameof(UrunId))]
        public Urun Urun { get; set; }


    }
}
