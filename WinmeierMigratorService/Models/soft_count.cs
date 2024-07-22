using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("sc_cage_session_id", Name = "IX_sc_cage_session_id")]
[Index("sc_status", Name = "IX_sc_status")]
public partial class soft_count
{
    [Key]
    public long sc_id { get; set; }

    public int sc_type { get; set; }

    [StringLength(50)]
    public string? sc_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sc_import_datetime { get; set; }

    public int sc_import_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sc_collection_datetime { get; set; }

    public int? sc_collection_user_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? sc_total_bills { get; set; }

    [Column(TypeName = "money")]
    public decimal? sc_total_tickets { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sc_delete_datetime { get; set; }

    public int? sc_delete_user_id { get; set; }

    public int sc_status { get; set; }

    public long? sc_file1_id { get; set; }

    public long? sc_file2_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sc_working_day { get; set; }

    public long? sc_cage_session_id { get; set; }

    [Column(TypeName = "xml")]
    public string sc_data { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string sc_money_collections { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string sc_warnings_errors { get; set; } = null!;
}
