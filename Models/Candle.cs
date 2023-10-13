using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LuminousCandle.Models
{
    public class Candle
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Delivery Date")]
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public string Wax { get; set; }

        [Required]
        public string Fragrance { get; set; }
        public int Rating { get; set; }


    }
}
