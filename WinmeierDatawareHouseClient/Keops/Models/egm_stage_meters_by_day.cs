using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("esmd_working_day", "esmd_site_id", "esmd_terminal_id")]
[Table("egm_stage_meters_by_day")]
public partial class egm_stage_meters_by_day
{
    [Key]
    public int esmd_working_day { get; set; }

    [Key]
    public int esmd_site_id { get; set; }

    [Key]
    public int esmd_terminal_id { get; set; }

    public int esmd_game_id { get; set; }

    public int? esmd_warning { get; set; }

    public bool? esmd_user_period_modified { get; set; }

    public bool? esmd_user_validated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? esmd_user_validated_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? esmd_last_updated { get; set; }

    public int? esmd_last_updated_user_id { get; set; }

    public bool esmd_connected { get; set; }

    public int esmd_status { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal? esmd_mc_0000_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal? esmd_mc_0001_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal? esmd_mc_0002_increment { get; set; }

    public long esmd_mc_0005_increment { get; set; }

    public long esmd_mc_0000 { get; set; }

    public long esmd_mc_0001 { get; set; }

    public long esmd_mc_0002 { get; set; }

    public long esmd_mc_0005 { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal? esmd_mc_0036_increment { get; set; }

    public long esmd_mc_0036 { get; set; }
}
