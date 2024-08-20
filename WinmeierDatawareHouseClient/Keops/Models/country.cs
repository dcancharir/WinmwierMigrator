using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("co_country_id", "co_language_id")]
public partial class country
{
    [Key]
    public int co_country_id { get; set; }

    [Key]
    public int co_language_id { get; set; }

    [StringLength(50)]
    public string co_name { get; set; } = null!;

    [StringLength(50)]
    public string co_adjective { get; set; } = null!;

    [StringLength(2)]
    public string co_iso2 { get; set; } = null!;

    [StringLength(7)]
    public string co_phone_code { get; set; } = null!;

    [StringLength(3)]
    public string? co_iso3 { get; set; }

    public bool co_tax_haven { get; set; }
}
