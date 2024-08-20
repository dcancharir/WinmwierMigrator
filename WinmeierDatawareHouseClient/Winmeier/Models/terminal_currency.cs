using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("terminal_currency")]
public partial class terminal_currency
{
    [Key]
    public int tc_id { get; set; }

    [StringLength(50)]
    public string? tc_name { get; set; }
}
