using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("esmp_working_day", "esmp_site_id", "esmp_terminal_id", "esmp_game_id", "esmp_denomination", "esmp_datetime", "esmp_record_type")]
[Table("egm_stage_meters_by_period")]
public partial class egm_stage_meters_by_period
{
    [Key]
    public int esmp_working_day { get; set; }

    [Key]
    public int esmp_site_id { get; set; }

    [Key]
    public int esmp_terminal_id { get; set; }

    [Key]
    public int esmp_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal esmp_denomination { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime esmp_datetime { get; set; }

    [Key]
    public int esmp_record_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? esmp_sas_accounting_denom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime esmp_last_created_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime esmp_last_reported_datetime { get; set; }

    public byte esmp_user_ignored { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? esmp_user_ignored_datetime { get; set; }

    public int? esmp_last_updated_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? esmp_last_updated_user_datetime { get; set; }

    public int esmp_status { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal esmp_mc_0000_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal esmp_mc_0001_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal esmp_mc_0002_increment { get; set; }

    public long esmp_mc_0005_increment { get; set; }

    public long esmp_mc_0000 { get; set; }

    public long esmp_mc_0001 { get; set; }

    public long esmp_mc_0002 { get; set; }

    public long esmp_mc_0005 { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal? esmp_mc_0036_increment { get; set; }

    public long esmp_mc_0036 { get; set; }
}
