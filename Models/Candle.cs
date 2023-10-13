using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LuminousCandle.Models
{
    public class Candle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Delivery Date")]
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public string Wax { get; set; }
        public string Fragrance { get; set; }


    }
}
