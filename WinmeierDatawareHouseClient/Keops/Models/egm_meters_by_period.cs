using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("emp_working_day", "emp_site_id", "emp_terminal_id", "emp_game_id", "emp_denomination", "emp_datetime", "emp_record_type")]
[Table("egm_meters_by_period")]
[Index("emp_working_day", "emp_site_id", "emp_terminal_id", "emp_datetime", Name = "IX_emp_workingday_site_terminal_datetime")]
public partial class egm_meters_by_period
{
    [Key]
    public int emp_working_day { get; set; }

    [Key]
    public int emp_site_id { get; set; }

    [Key]
    public int emp_terminal_id { get; set; }

    [Key]
    public int emp_game_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal emp_denomination { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime emp_datetime { get; set; }

    [Key]
    public int emp_record_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? emp_sas_accounting_denom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime emp_last_created_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime emp_last_reported_datetime { get; set; }

    public byte emp_user_ignored { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? emp_user_ignored_datetime { get; set; }

    public int? emp_last_updated_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? emp_last_updated_user_datetime { get; set; }

    public int emp_status { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal emp_mc_0000_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal emp_mc_0001_increment { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal emp_mc_0002_increment { get; set; }

    public long emp_mc_0005_increment { get; set; }

    public long emp_mc_0000 { get; set; }

    public long emp_mc_0001 { get; set; }

    public long emp_mc_0002 { get; set; }

    public long emp_mc_0005 { get; set; }
}
