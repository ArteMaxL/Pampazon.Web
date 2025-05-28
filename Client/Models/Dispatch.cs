using System;

namespace Pampazon.Web.Client.Models
{
    // DispatchStatus enum removed, backend uses IsFinalized boolean
    // public enum DispatchStatus 
    // {
    //     InProgress,
    //     Finalized,
    //     Delivered 
    // }

    public class Dispatch
    {
        public string DispatchNumber { get; set; } = string.Empty;
        // Removed OrderNumber
        // Removed Order navigation property
        public DateTime Date { get; set; } // Was CreatedAt, matches backend "date"
        public string CarrierCUIT { get; set; } = string.Empty;
        public bool IsFinalized { get; set; }
        // Removed DeliveredAt
        // Removed Status enum field
    }
} 