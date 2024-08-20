using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class occupation
{
    public int oc_id { get; set; }

    [StringLength(510)]
    public string oc_description { get; set; } = null!;

    [StringLength(20)]
    public string oc_code { get; set; } = null!;

    public bool oc_enabled { get; set; }

    public int oc_order { get; set; }

    [StringLength(4)]
    public string oc_country_iso_code2 { get; set; } = null!;
}
