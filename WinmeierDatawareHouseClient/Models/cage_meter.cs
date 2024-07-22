using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("cm_source_target_id", "cm_concept_id", "cm_iso_code", "cm_cage_currency_type")]
public partial class cage_meter
{
    [Key]
    public long cm_source_target_id { get; set; }

    [Key]
    public long cm_concept_id { get; set; }

    [Key]
    [StringLength(3)]
    public string cm_iso_code { get; set; } = null!;

    [Key]
    public int cm_cage_currency_type { get; set; }

    [Column(TypeName = "money")]
    public decimal cm_value { get; set; }

    [Column(TypeName = "money")]
    public decimal cm_value_in { get; set; }

    [Column(TypeName = "money")]
    public decimal cm_value_out { get; set; }
}
