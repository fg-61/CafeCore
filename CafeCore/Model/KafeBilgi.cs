using CafeCore.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeCore.Model
{
    public class KafeBilgi : BaseEntity, IKey
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(30, ErrorMessage = "Ad alanı en fazla 30 karakter olmalı")]
        public string Ad { get; set; } = "Kafe Core";
        [Required, StringLength(30, ErrorMessage = "Telefon 11 karakter olmalı")]
        public string Telefon { get; set; } = "05551234567";
        [Required, StringLength(30, ErrorMessage = "Adres alanı en fazla 150 karakter olmalı")]
        public string Adres { get; set; } = "Beşiktaş-İstanbul";
    }
}
