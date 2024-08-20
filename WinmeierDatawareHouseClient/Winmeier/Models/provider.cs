using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("pv_name", Name = "IX_pv_name", IsUnique = true)]
public partial class provider
{
    [Key]
    public int pv_id { get; set; }

    [StringLength(50)]
    public string pv_name { get; set; } = null!;

    public bool pv_hide { get; set; }

    [Column(TypeName = "money")]
    public decimal pv_points_multiplier { get; set; }

    public bool pv_3gs { get; set; }

    [StringLength(50)]
    public string? pv_3gs_vendor_id { get; set; }

    [StringLength(50)]
    public string? pv_3gs_vendor_ip { get; set; }

    public bool pv_site_jackpot { get; set; }

    public bool pv_only_redeemable { get; set; }

    public byte[]? pv_timestamp { get; set; }

    public long? pv_ms_sequence_id { get; set; }
}
