using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("app_name", "app_alias", Name = "IX_app_name_alias", IsUnique = true)]
[Index("app_name", "app_machine", Name = "IX_app_name_machine", IsUnique = true)]
public partial class application
{
    [Key]
    public long app_id { get; set; }

    [StringLength(50)]
    public string app_name { get; set; } = null!;

    [StringLength(50)]
    public string app_version { get; set; } = null!;

    [StringLength(50)]
    public string app_machine { get; set; } = null!;

    [StringLength(50)]
    public string app_ip_address { get; set; } = null!;

    [StringLength(50)]
    public string app_os_username { get; set; } = null!;

    [StringLength(50)]
    public string app_login_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime app_last_access { get; set; }

    [StringLength(50)]
    public string? app_alias { get; set; }
}
