using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("terminal_currency")]
public partial class terminal_currency
{
    public int tc_id { get; set; }

    [StringLength(100)]
    public string? tc_name { get; set; }
}
