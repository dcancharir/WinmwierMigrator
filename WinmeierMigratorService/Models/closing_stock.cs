using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class closing_stock
{
    [Key]
    public long cs_cashier_id { get; set; }

    public int cs_closing_stock_type { get; set; }

    public bool cs_sleeps_on_table { get; set; }

    [Column(TypeName = "xml")]
    public string? cs_stock { get; set; }
}
