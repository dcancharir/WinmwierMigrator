using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class pattern
{
    [Key]
    public long pt_id { get; set; }

    [StringLength(50)]
    public string pt_name { get; set; } = null!;

    [StringLength(350)]
    public string pt_description { get; set; } = null!;

    public bool pt_active { get; set; }

    [Column(TypeName = "xml")]
    public string pt_pattern { get; set; } = null!;

    public int pt_al_code { get; set; }

    [StringLength(50)]
    public string pt_al_name { get; set; } = null!;

    [StringLength(350)]
    public string? pt_al_description { get; set; }

    public int pt_al_severity { get; set; }

    public int pt_type { get; set; }

    public int pt_source { get; set; }

    public int pt_life_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pt_last_find { get; set; }

    public int pt_detections { get; set; }

    [Column(TypeName = "xml")]
    public string? pt_restricted_to_terminal_list { get; set; }

    public int? pt_schedule_time_from { get; set; }

    public int? pt_schedule_time_to { get; set; }

    public long? pt_timestamp { get; set; }

    public bool pt_active_mailing { get; set; }

    [StringLength(500)]
    public string? pt_address_list { get; set; }

    [StringLength(200)]
    public string? pt_subject { get; set; }
}
