using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Ensure this is present
// Assuming Pampazon.Web.Client.Models.Enums or similar for OrderStatus
// If not, it should be defined here or in a separate Enums.cs

namespace Pampazon.Web.Client.Models
{
    // Define Enums if not already present in a shared/client Enums location
    // For example:
    // public enum OrderStatus // Ensure this matches backend Pampazon.Enums.OrderStatus
    // {
    //     Pending,
    //     Prepared,
    //     Dispatched,
    //     Delivered, // Assuming from backend context, adjust if different
    //     Cancelled  // Assuming from backend context, adjust if different
    // }

    // OrderStatus enum values (from Swagger): 0, 1, 2. Assuming 0 = Pending.

    public class OrderItem
    {
        // Removed Id
        public string ProductCode { get; set; } = string.Empty; // Was ProductId, matches backend
        public Product? Product { get; set; } // Frontend convenience
        public int Quantity { get; set; }
        // Removed OrderNumber (link back to Order)
    }

    public class Order
    {
        public string OrderNumber { get; set; } = string.Empty; // Assuming backend generated, nullable for create?
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Client ID is required.")] // Changed from Client CUIT
        [RegularExpression(@"^\d{2}-\d{8}-\d{1}$", ErrorMessage = "Client ID (CUIT) must be in the format XX-XXXXXXXX-X.")]
        public string ClientId { get; set; } = string.Empty; // Was ClientCUIT
        public Client? Client { get; set; } // Frontend convenience

        [Required(ErrorMessage = "Recipient Name is required.")]
        [StringLength(100, ErrorMessage = "Recipient Name cannot exceed 100 characters.")]
        public string RecipientName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Recipient Address is required.")]
        [StringLength(200, ErrorMessage = "Recipient Address cannot exceed 200 characters.")]
        public string RecipientAddress { get; set; } = string.Empty;
        
        public string Status { get; set; } = string.Empty; // Reverted to string
        // Removed DispatchNumber
        // Removed Dispatch navigation property
        // Removed Receipt navigation property
        public List<OrderItem> Items { get; set; } = new();
    }
} 