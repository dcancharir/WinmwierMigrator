using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("ppl_provision_id", "ppl_level_id")]
public partial class progressives_provisions_level
{
    [Key]
    public long ppl_provision_id { get; set; }

    [Key]
    public int ppl_level_id { get; set; }

    [Column(TypeName = "money")]
    public decimal ppl_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ppl_theoretical_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ppl_current_amount { get; set; }
}
