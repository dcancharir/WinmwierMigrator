using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class pinpad_cashier_terminal
{
    public int pct_id { get; set; }

    public int pct_cashier_id { get; set; }

    public int pct_type { get; set; }

    public int pct_port { get; set; }

    public bool pct_enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pct_last_modified { get; set; }

    [StringLength(1000)]
    public string? pct_api_url { get; set; }

    [StringLength(1000)]
    public string? pct_api_id { get; set; }

    [StringLength(1000)]
    public string? pct_api_key { get; set; }

    [StringLength(1000)]
    public string? pct_api_pos { get; set; }

    [StringLength(1000)]
    public string? pct_api_enc_identifier { get; set; }

    [StringLength(1000)]
    public string? pct_api_enc_passphrase { get; set; }
}
