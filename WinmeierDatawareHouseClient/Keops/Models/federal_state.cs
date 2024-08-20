using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class federal_state
{
    public int fs_state_id { get; set; }

    [StringLength(100)]
    public string fs_name { get; set; } = null!;

    [StringLength(4)]
    public string fs_country_iso_code2 { get; set; } = null!;

    public int? fs_cfdi_id { get; set; }

    [StringLength(6)]
    public string? fs_abbreviation { get; set; }
}
