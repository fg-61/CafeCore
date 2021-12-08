using KuzeyCodeFirst.Models.BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeCore.Model
{
    [Table("Masalar")]
    public class Masa : BaseEntity, IKey
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int No { get; set; } = 1;

        [Required]
        public bool Durum { get; set; } = false;

        [Required]
        public int KatId { get; set; }
        [ForeignKey(nameof(KatId))]
        public Kat Kat { get; set; }

        public ICollection<Siparis> Siparisler { get; set; } = new HashSet<Siparis>();
    }
}
