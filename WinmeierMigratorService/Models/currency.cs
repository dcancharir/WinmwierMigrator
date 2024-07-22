using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class currency
{
    [Key]
    [StringLength(3)]
    public string cur_iso_code { get; set; } = null!;

    public bool cur_allowed { get; set; }

    [StringLength(50)]
    public string? cur_name { get; set; }

    [StringLength(3)]
    public string? cur_alias1 { get; set; }

    [StringLength(3)]
    public string? cur_alias2 { get; set; }

    [InverseProperty("cud_iso_codeNavigation")]
    public virtual ICollection<currency_denomination> currency_denominations { get; set; } = new List<currency_denomination>();

    [InverseProperty("gt_cur_iso_codeNavigation")]
    public virtual ICollection<gaming_table> gaming_tables { get; set; } = new List<gaming_table>();
}
