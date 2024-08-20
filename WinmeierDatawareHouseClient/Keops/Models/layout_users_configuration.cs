using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("layout_users_configuration")]
public partial class layout_users_configuration
{
    [Key]
    public int lc_user_id { get; set; }

    [Unicode(false)]
    public string lc_parameters { get; set; } = null!;

    [Unicode(false)]
    public string? lc_dashboard { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime lc_last_update { get; set; }

    public bool lc_is_manager { get; set; }

    public bool lc_is_runner { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LC_PROFILE_UPDATE { get; set; }

    public bool lc_is_active { get; set; }
}
