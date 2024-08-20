using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("nls_id", "nls_key")]
public partial class nls_value
{
    [Key]
    public int nls_id { get; set; }

    [Key]
    [StringLength(100)]
    public string nls_key { get; set; } = null!;

    [Column("nls_value")]
    public string? nls_value1 { get; set; }
}
