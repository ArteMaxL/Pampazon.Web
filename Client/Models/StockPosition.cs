using System;
using System.ComponentModel.DataAnnotations;

namespace Pampazon.Web.Client.Models
{
    public class StockPosition
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product ID is required.")]
        public string ProductId { get; set; } = string.Empty;
        public Product? Product { get; set; }

        [Required(ErrorMessage = "Client ID (CUIT) is required.")]
        public string ClientId { get; set; } = string.Empty;
        public Client? Client { get; set; }

        [Required(ErrorMessage = "Receipt Number is required.")]
        public string ReceiptNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative number.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Aisle is required.")]
        public string Aisle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Section is required.")]
        public string Section { get; set; } = string.Empty;

        [Required(ErrorMessage = "Shelf is required.")]
        public string Shelf { get; set; } = string.Empty;

        [Required(ErrorMessage = "Level is required.")]
        public string Level { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; }

        public string GetPositionCode()
        {
            return $"{Aisle}.{Section}.{Shelf}.{Level}";
        }
    }
} 