using System;
using System.ComponentModel.DataAnnotations;

namespace KuzeyCodeFirst.Models.BaseEntity
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }

    public interface IKey
    {
        [Key]
        public int Id { get; set; }
    }
}
