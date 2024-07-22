using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class occupation
{
    [Key]
    public int oc_id { get; set; }

    [StringLength(255)]
    public string oc_description { get; set; } = null!;

    [StringLength(10)]
    public string oc_code { get; set; } = null!;

    public bool oc_enabled { get; set; }

    public int oc_order { get; set; }

    [StringLength(2)]
    public string oc_country_iso_code2 { get; set; } = null!;
}
