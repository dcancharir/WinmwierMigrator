using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("hierarchy.organization")]
public partial class hierarchy_organization
{
    [Key]
    public Guid ho_id { get; set; }

    public bool? ho_enabled { get; set; }

    public byte? ho_type { get; set; }

    [StringLength(50)]
    public string? ho_name { get; set; }

    public byte? ho_levels { get; set; }

    [StringLength(50)]
    public string? ho_visible { get; set; }

    [StringLength(50)]
    public string? ho_tooltip { get; set; }

    [StringLength(50)]
    public string? ho_filter { get; set; }

    [StringLength(50)]
    public string? ho_editable { get; set; }
}
