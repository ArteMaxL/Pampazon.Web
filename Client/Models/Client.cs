using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pampazon.Web.Client.Models;

public class Client
{
    [Required(ErrorMessage = "CUIT is required.")]
    [RegularExpression(@"^\d{2}-\d{8}-\d{1}$", ErrorMessage = "CUIT must be in the format XX-XXXXXXXX-X (e.g., 20-12345678-9).")]
    public string? CUIT { get; set; }

    [Required(ErrorMessage = "Business Name is required.")]
    public string BusinessName { get; set; } = string.Empty;

    // Assuming RentedPositions will be handled later or is not part of initial form validation.
    // public List<StockPosition> RentedPositions { get; set; } = new();
} 