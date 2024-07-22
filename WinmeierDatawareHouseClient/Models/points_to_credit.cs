using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class points_to_credit
{
    [Key]
    public long ptc_points_to_credits_id { get; set; }

    [StringLength(50)]
    public string ptc_name { get; set; } = null!;

    [StringLength(200)]
    public string? ptc_description { get; set; }

    public bool ptc_enabled { get; set; }

    public int ptc_credit_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ptc_updated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ptc_updated_by_thread { get; set; }

    public int ptc_schedule_weekday { get; set; }

    public int ptc_schedule1_time_from { get; set; }

    public int ptc_schedule1_time_to { get; set; }

    public bool ptc_schedule2_enabled { get; set; }

    public int? ptc_schedule2_time_from { get; set; }

    public int? ptc_schedule2_time_to { get; set; }

    [Column(TypeName = "xml")]
    public string? ptc_restricted_to_terminal_list_0 { get; set; }

    [Column(TypeName = "xml")]
    public string? ptc_restricted_to_terminal_list_1 { get; set; }

    [Column(TypeName = "xml")]
    public string? ptc_restricted_to_terminal_list_2 { get; set; }

    [Column(TypeName = "xml")]
    public string? ptc_restricted_to_terminal_list_3 { get; set; }

    [Column(TypeName = "xml")]
    public string? ptc_restricted_to_terminal_list_4 { get; set; }

    [Column(TypeName = "xml")]
    public string? ptc_restricted_to_terminal_list_5 { get; set; }

    [Column(TypeName = "xml")]
    public string? ptc_restricted_to_terminal_list_6 { get; set; }

    [StringLength(3)]
    public string? ptc_name_prefix { get; set; }
}
