using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class safe_keeping_account
{
    public long ska_safe_keeping_id { get; set; }

    public int? ska_block_reason { get; set; }

    public int? ska_owner_document_type { get; set; }

    [StringLength(40)]
    public string? ska_owner_document_id { get; set; }

    [StringLength(400)]
    public string? ska_owner_name { get; set; }

    [StringLength(100)]
    public string? ska_owner_name1 { get; set; }

    [StringLength(100)]
    public string? ska_owner_name2 { get; set; }

    [StringLength(100)]
    public string? ska_owner_name3 { get; set; }

    [StringLength(100)]
    public string? ska_owner_name4 { get; set; }

    [Column(TypeName = "money")]
    public decimal ska_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal? ska_max_balance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ska_last_operation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ska_created { get; set; }

    public long? ska_account_id { get; set; }
}
