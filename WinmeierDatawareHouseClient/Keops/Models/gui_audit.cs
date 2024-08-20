using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ga_audit_id", "ga_item_order")]
[Table("gui_audit")]
[Index("ga_datetime", Name = "IX_gui_audit_ga_datetime")]
[Index("ga_gui_user_id", Name = "IX_gui_audit_ga_gui_user_id")]
[Index("ga_related_type", "ga_related_id", Name = "IX_gui_related_type_related_id")]
public partial class gui_audit
{
    [Key]
    public long ga_audit_id { get; set; }

    [Key]
    public int ga_item_order { get; set; }

    public int ga_gui_id { get; set; }

    public int? ga_gui_user_id { get; set; }

    [StringLength(50)]
    public string ga_gui_username { get; set; } = null!;

    [StringLength(50)]
    public string ga_computer_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ga_datetime { get; set; }

    public int ga_audit_code { get; set; }

    public int ga_audit_level { get; set; }

    public int? ga_nls_id { get; set; }

    [StringLength(150)]
    public string? ga_nls_param01 { get; set; }

    [StringLength(150)]
    public string? ga_nls_param02 { get; set; }

    [StringLength(150)]
    public string? ga_nls_param03 { get; set; }

    [StringLength(50)]
    public string? ga_nls_param04 { get; set; }

    [StringLength(50)]
    public string? ga_nls_param05 { get; set; }

    public int? ga_related_type { get; set; }

    public long? ga_related_id { get; set; }

    [StringLength(10)]
    public string? ga_external_venue_id { get; set; }

    public int? ga_venue_type_id { get; set; }
}
