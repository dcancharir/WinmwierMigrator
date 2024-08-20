using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_site_task
{
    public long lst_id { get; set; }

    public int lst_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_end { get; set; }

    public int? lst_category { get; set; }

    public int? lst_subcategory { get; set; }

    public int? lst_terminal_id { get; set; }

    public long? lst_account_id { get; set; }

    [StringLength(500)]
    public string? lst_description { get; set; }

    public int? lst_severity { get; set; }

    public int lst_creation_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime lst_creation { get; set; }

    public int? lst_assigned_role_id { get; set; }

    public int? lst_assigned_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_assigned { get; set; }

    public int? lst_accepted_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_accepted { get; set; }

    public int? lst_scale_from_user_id { get; set; }

    public int? lst_scale_to_user_id { get; set; }

    [StringLength(500)]
    public string? lst_scale_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_scale { get; set; }

    public int? lst_solved_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_solved { get; set; }

    public int? lst_validate_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_validate { get; set; }

    public int? lst_last_status_update_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lst_last_status_update { get; set; }

    public int? lst_attached_media { get; set; }

    public string? lst_events_history { get; set; }

    [StringLength(100)]
    public string? lst_title { get; set; }

    public int? lst_assigned_area_id { get; set; }
}
