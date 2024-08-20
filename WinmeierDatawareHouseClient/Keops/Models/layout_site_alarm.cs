using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("lsa_terminal_id", "lsa_alarm_id", "lsa_date_created")]
[Index("lsa_date_created", Name = "IX_lsa_date_created")]
[Index("lsa_date_to_task", "lsa_task_id", "lsa_status", Name = "IX_lsa_date_to_task_taskid_status")]
[Index("lsa_id", Name = "IX_lsa_id")]
[Index("lsa_date_created", Name = "XI_layout_site_alarms_datecreated")]
[Index("lsa_status", Name = "XI_layout_site_alarms_status")]
public partial class layout_site_alarm
{
    [Key]
    public int lsa_terminal_id { get; set; }

    [Key]
    public long lsa_alarm_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime lsa_date_created { get; set; }

    public long lsa_id { get; set; }

    public int lsa_alarm_type { get; set; }

    public int lsa_alarm_source { get; set; }

    public int lsa_user_created { get; set; }

    public long? lsa_media_id { get; set; }

    public string? lsa_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lsa_date_to_task { get; set; }

    public long? lsa_task_id { get; set; }

    public int lsa_status { get; set; }

    [StringLength(50)]
    public string? lsa_title { get; set; }

    public long? lsa_external_id { get; set; }

    public long? lsa_account_id { get; set; }

    public bool? lsa_abandoned { get; set; }
}
