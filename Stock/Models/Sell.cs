using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Models
{
    public class Sell
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        [Required]
        public string ProductCode { get; set; }
        [MaxLength(25)]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [MaxLength(20)]
        [Required]
        public string Unit { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Recieved { get; set; }
        [Required]
        public int Return { get; set; }
    }
}
