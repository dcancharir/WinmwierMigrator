using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_users_custom_filter
{
    public int lcf_id { get; set; }

    public int lcf_user_id { get; set; }

    [StringLength(100)]
    public string lcf_name { get; set; } = null!;

    public string lcf_filter_parameters { get; set; } = null!;

    public bool lcf_enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime lcf_last_update { get; set; }

    public string lcf_display { get; set; } = null!;
}
