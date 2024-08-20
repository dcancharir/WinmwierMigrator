using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class hot_seat_execution
{
    public long hse_id { get; set; }

    public long hse_hot_seat_id { get; set; }

    public int? hse_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hse_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hse_start_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hse_end_date { get; set; }

    [StringLength(6)]
    public string hse_iso_code { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string? hse_terminals { get; set; }

    public int? hse_by_gender { get; set; }

    public int? hse_by_date_of_birth { get; set; }

    public int? hse_by_level { get; set; }

    public int? hse_vip { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hse_last_update { get; set; }

    [Column(TypeName = "xml")]
    public string? hse_terminal_ids { get; set; }
}
