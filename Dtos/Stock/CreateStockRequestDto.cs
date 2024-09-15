using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage ="the symbol canot be more than 10 character")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(10, ErrorMessage ="the CompanyName canot be more than 10 character")]

        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
    }
}