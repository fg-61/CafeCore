using System;
using System.ComponentModel.DataAnnotations;

namespace CafeCore.Model.Abstracts
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }

    public interface IKey
    {
        [Key]
        public int Id { get; set; }
    }
}
