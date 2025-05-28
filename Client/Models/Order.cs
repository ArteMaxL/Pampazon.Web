using System;
using System.Collections.Generic;
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
        public string OrderNumber { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string ClientCUIT { get; set; } = string.Empty; // Was ClientId, matches backend
        public Client? Client { get; set; } // Frontend convenience
        public string RecipientName { get; set; } = string.Empty;
        public string RecipientAddress { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Was OrderStatus enum, now string
        // Removed DispatchNumber
        // Removed Dispatch navigation property
        // Removed Receipt navigation property
        public List<OrderItem> Items { get; set; } = new();
    }
} 