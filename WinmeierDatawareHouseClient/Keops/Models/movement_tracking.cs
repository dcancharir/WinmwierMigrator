using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("movement_tracking")]
public partial class movement_tracking
{
    public long mt_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mt_date { get; set; }

    public int mt_movement_id { get; set; }

    public int mt_user_id { get; set; }

    [StringLength(200)]
    public string mt_username { get; set; } = null!;

    public int? mt_terminal_type_id { get; set; }

    public int? mt_egm_id { get; set; }

    public int? mt_equipment_type_id { get; set; }

    [StringLength(500)]
    public string mt_name { get; set; } = null!;

    public int? mt_from_venue_id { get; set; }

    public int? mt_from_area_id { get; set; }

    public int? mt_from_bank_id { get; set; }

    public int? mt_from_position { get; set; }

    [StringLength(500)]
    public string? mt_from_floor { get; set; }

    [StringLength(30)]
    public string? mt_from_location_historical { get; set; }

    [StringLength(70)]
    public string? mt_from_venue_historical { get; set; }

    [StringLength(500)]
    public string? mt_from_floor_historical { get; set; }

    public int mt_to_venue_id { get; set; }

    public int mt_to_area_id { get; set; }

    public int mt_to_bank_id { get; set; }

    public int? mt_to_position { get; set; }

    [StringLength(500)]
    public string? mt_to_floor { get; set; }

    [StringLength(30)]
    public string? mt_to_location_historical { get; set; }

    [StringLength(70)]
    public string? mt_to_venue_historical { get; set; }

    [StringLength(500)]
    public string? mt_to_floor_historical { get; set; }

    [StringLength(1024)]
    public string? mt_comment { get; set; }
}
