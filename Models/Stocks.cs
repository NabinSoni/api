using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Stocks
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string ComapnyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public string MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}