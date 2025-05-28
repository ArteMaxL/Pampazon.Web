using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pampazon.Web.Client.Models
{
    // ReceiptStatus enum values (from Swagger): 0, 1, 2. Assuming 0 = PendingEntry.

    public class ReceiptItem // Assuming this matches backend structure
    {
        public string ProductCode { get; set; } = string.Empty;
        public Product? Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Receipt
    {
        public string? ReceiptNumber { get; set; } // Was Id (int), now string? to match backend 'receiptNumber' (nullable for create)

        [Required(ErrorMessage = "Client ID is required.")] // Changed from Client CUIT
        // Regex for CUIT can remain if ClientId is still a CUIT, but label changed
        [RegularExpression(@"^\d{2}-\d{8}-\d{1}$", ErrorMessage = "Client ID (CUIT) must be in the format XX-XXXXXXXX-X.")]
        public string ClientId { get; set; } = string.Empty; // Was ClientCUIT

        public Client? Client { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = string.Empty; // Reverted to string

        // CarrierCUIT removed as it's not in backend Pampazon.Models.Receipt
        
        public List<ReceiptItem> Items { get; set; } = new();
    }
} 