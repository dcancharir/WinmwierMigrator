using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class blacklist_positive_case
{
    public int bpc_id { get; set; }

    [StringLength(250)]
    public string? bpc_fullname { get; set; }

    public short? bpc_document_type { get; set; }

    [StringLength(150)]
    public string? bpc_document { get; set; }

    public bool? bpc_authorized { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? bpc_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? bpc_blacklist_date { get; set; }

    public short? bpc_reason_type { get; set; }

    [StringLength(250)]
    public string? bpc_reason_description { get; set; }

    [StringLength(50)]
    public string? bpc_cashier { get; set; }

    [StringLength(50)]
    public string? bpc_terminal { get; set; }

    public short? bpc_blacklist_source { get; set; }

    public int? bpc_blacklist_type { get; set; }
}
