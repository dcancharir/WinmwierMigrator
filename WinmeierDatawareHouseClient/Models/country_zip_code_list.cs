using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Keyless]
[Table("country_zip_code_list")]
[Index("czl_country_iso2", "czl_zip_code", Name = "IX_czl_country_iso2_czl_zip_code")]
public partial class country_zip_code_list
{
    [StringLength(2)]
    public string czl_country_iso2 { get; set; } = null!;

    [StringLength(10)]
    public string czl_zip_code { get; set; } = null!;

    [StringLength(50)]
    public string? czl_addr_01 { get; set; }

    [StringLength(50)]
    public string? czl_addr_02 { get; set; }

    [StringLength(50)]
    public string? czl_addr_03 { get; set; }

    [StringLength(50)]
    public string? czl_addr_04 { get; set; }

    [StringLength(50)]
    public string? czl_addr_05 { get; set; }
}
