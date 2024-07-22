using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("emd_working_day", "emd_site_id", "emd_terminal_id")]
[Table("egm_meters_by_day")]
[Index("emd_working_day", "emd_site_id", "emd_terminal_id", Name = "IX_emd_workingday_site_terminal", IsUnique = true)]
public partial class egm_meters_by_day
{
    [Key]
    public int emd_working_day { get; set; }

    [Key]
    public int emd_site_id { get; set; }

    [Key]
    public int emd_terminal_id { get; set; }

    public int emd_game_id { get; set; }

    public int? emd_warning { get; set; }

    public bool? emd_user_period_modified { get; set; }

    public bool? emd_user_validated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? emd_user_validated_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? emd_last_updated { get; set; }

    public int? emd_last_updated_user_id { get; set; }

    public bool emd_connected { get; set; }

    public int emd_status { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal emd_mc_0000_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal emd_mc_0001_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal emd_mc_0002_increment { get; set; }

    public long emd_mc_0005_increment { get; set; }

    public long emd_mc_0000 { get; set; }

    public long emd_mc_0001 { get; set; }

    public long emd_mc_0002 { get; set; }

    public long emd_mc_0005 { get; set; }
}
