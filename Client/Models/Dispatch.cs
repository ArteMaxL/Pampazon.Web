using System;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Dispatch Number is required.")]
        [StringLength(50, ErrorMessage = "Dispatch Number cannot exceed 50 characters.")]
        public string DispatchNumber { get; set; } = string.Empty;
        // Removed OrderNumber
        // Removed Order navigation property
        public DateTime Date { get; set; } // Was CreatedAt, matches backend "date"
        [Required(ErrorMessage = "Carrier CUIT is required.")]
        [RegularExpression(@"^\d{2}-\d{8}-\d{1}$", ErrorMessage = "Carrier CUIT must be in the format XX-XXXXXXXX-X.")]
        public string CarrierCUIT { get; set; } = string.Empty;
        public bool IsFinalized { get; set; }
        // Removed DeliveredAt
        // Removed Status enum field
    }
} 