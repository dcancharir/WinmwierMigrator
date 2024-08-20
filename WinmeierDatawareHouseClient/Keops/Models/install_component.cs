using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class install_component
{
    public int Id { get; set; }

    [StringLength(400)]
    public string Update_origin { get; set; } = null!;

    [StringLength(600)]
    public string? Component_name { get; set; }

    [StringLength(200)]
    public string? Component_version { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Init_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? End_time { get; set; }

    [StringLength(100)]
    public string? Installed { get; set; }

    [StringLength(100)]
    public string? Repo_copy_1 { get; set; }

    [StringLength(100)]
    public string? Repo_copy_2 { get; set; }

    public string? LogPath { get; set; }
}
