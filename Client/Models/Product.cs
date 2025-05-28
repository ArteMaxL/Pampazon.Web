using System.Collections.Generic;

namespace Pampazon.Web.Client.Models;

public class Product
{
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Height { get; set; }
    public decimal Width { get; set; }
    public decimal Depth { get; set; }
} 