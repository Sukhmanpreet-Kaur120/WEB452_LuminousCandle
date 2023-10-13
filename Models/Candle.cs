using System;
using System.ComponentModel.DataAnnotations;

namespace LuminousCandle.Models
{
    public class Candle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public string Wax { get; set; }
        public string Fragrance { get; set; }


    }
}
