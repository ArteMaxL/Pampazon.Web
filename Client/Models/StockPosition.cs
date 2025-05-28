using System;

namespace Pampazon.Web.Client.Models
{
    public class StockPosition
    {
        public int Id { get; set; }

        public string ProductCode { get; set; } = string.Empty;
        public Product? Product { get; set; }

        public string ClientId { get; set; } = string.Empty;
        public Client? Client { get; set; }

        public int Quantity { get; set; }

        public string Aisle { get; set; } = string.Empty;
        public int Section { get; set; }
        public int Shelf { get; set; }
        public int Level { get; set; }

        public string GetPositionCode()
        {
            return $"{Aisle}.{Section}.{Shelf}.{Level}";
        }
    }
} 