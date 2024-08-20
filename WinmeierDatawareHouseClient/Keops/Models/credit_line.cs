using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class credit_line
{
    public long cl_id { get; set; }

    public long cl_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal cl_limit_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? cl_tto_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal cl_spent_amount { get; set; }

    [StringLength(6)]
    public string cl_iso_code { get; set; } = null!;

    public int cl_status { get; set; }

    [StringLength(68)]
    public string? cl_iban { get; set; }

    [Column(TypeName = "xml")]
    public string? cl_xml_signers { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cl_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cl_update { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cl_expired { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cl_last_payback { get; set; }

    public byte[] cl_timestamp { get; set; } = null!;
}
