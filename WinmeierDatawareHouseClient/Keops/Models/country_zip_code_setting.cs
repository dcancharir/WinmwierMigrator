using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class country_zip_code_setting
{
    [Key]
    [StringLength(2)]
    public string czs_country_iso2 { get; set; } = null!;

    public int czs_mode { get; set; }

    [StringLength(50)]
    public string? czs_format { get; set; }

    [StringLength(50)]
    public string? czs_regex { get; set; }

    public int? czs_addr_01 { get; set; }

    public int? czs_addr_02 { get; set; }

    public int? czs_addr_03 { get; set; }

    public int? czs_addr_04 { get; set; }

    public int? czs_addr_05 { get; set; }
}
