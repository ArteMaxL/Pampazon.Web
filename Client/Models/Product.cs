using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pampazon.Web.Client.Models;

public class Product
{
    [Required(ErrorMessage = "Product Code is required.")]
    [RegularExpression(@"^[A-Z]{3}-\d{4}$", ErrorMessage = "Product Code must be in the format XXX-0000 (e.g., ABC-1234).")]
    public string? Code { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    public string Description { get; set; } = string.Empty;

    [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Height must be greater than 0.")]
    public decimal Height { get; set; }

    [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Width must be greater than 0.")]
    public decimal Width { get; set; }

    [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Depth must be greater than 0.")]
    public decimal Depth { get; set; }
} 