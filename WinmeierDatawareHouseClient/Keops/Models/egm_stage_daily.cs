using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("esd_working_day", "esd_site_id")]
[Table("egm_stage_daily")]
public partial class egm_stage_daily
{
    [Key]
    public int esd_working_day { get; set; }

    [Key]
    public int esd_site_id { get; set; }

    public byte esd_status { get; set; }

    public bool esd_has_new_meters { get; set; }

    public int esd_terminals_connected { get; set; }

    public int esd_terminals_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? esd_last_updated_meters { get; set; }

    public int? esd_last_updated_user { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? esd_last_updated_user_datetime { get; set; }

    public bool esd_is_calculated { get; set; }

    public byte[]? esd_timestamp { get; set; }

    [Column(TypeName = "decimal(20, 2)")]
    public decimal? esd_netwin { get; set; }

    public long? esd_lottery_sync_mark { get; set; }
}
