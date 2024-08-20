using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class venue
{
    public int ve_venue_id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ve_external_venue_id { get; set; } = null!;

    public int ve_venue_type_id { get; set; }

    [StringLength(40)]
    public string ve_shortname { get; set; } = null!;

    [StringLength(500)]
    public string ve_fullname { get; set; } = null!;

    [StringLength(500)]
    public string? ve_location { get; set; }

    [StringLength(100)]
    public string? ve_geolocation { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ve_zipcode { get; set; }

    public int ve_status_id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ve_surface_m2 { get; set; }

    public bool ve_enable { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ve_disabletime { get; set; }

    [StringLength(512)]
    public string? ve_reason { get; set; }

    [Column(TypeName = "money")]
    public decimal? ve_threshold_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ve_netwin_pct { get; set; }

    public int? ve_vault_id { get; set; }

    public int? ve_operator_id { get; set; }

    [StringLength(100)]
    public string? ve_dbversion { get; set; }

    [StringLength(100)]
    public string? ve_db_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ve_db_update { get; set; }
}
