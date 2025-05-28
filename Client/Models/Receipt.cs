using System;
using System.Collections.Generic;

namespace Pampazon.Web.Client.Models
{
    // ReceiptStatus enum removed, will use string to match backend
    // public enum ReceiptStatus 
    // {
    //     Pending,
    //     InProgress,
    //     Completed,
    //     Cancelled
    // }

    public class ReceiptItem
    {
        // Removed Id
        // Removed ReceiptNumber
        public string ProductCode { get; set; } = string.Empty; // Was ProductId, matches backend
        public Product? Product { get; set; } // Frontend convenience
        public int Quantity { get; set; }
    }

    public class Receipt
    {
        public int Id { get; set; } // Was ReceiptNumber (string), now int Id to match backend
        public string ClientCUIT { get; set; } = string.Empty; // Was ClientId, matches backend
        public Client? Client { get; set; } // Frontend convenience
        public DateTime Date { get; set; }
        public string Status { get; set; } = string.Empty; // Was ReceiptStatus enum, now string
        public string? CarrierCUIT { get; set; } = string.Empty; // Added from backend model
        // Removed CompletedAt
        public List<ReceiptItem> Items { get; set; } = new();
    }
} 