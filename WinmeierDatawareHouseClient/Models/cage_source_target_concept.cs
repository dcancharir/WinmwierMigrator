using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("cstc_concept_id", "cstc_source_target_id", "cstc_type")]
public partial class cage_source_target_concept
{
    [Key]
    public long cstc_concept_id { get; set; }

    [Key]
    public long cstc_source_target_id { get; set; }

    [Key]
    public int cstc_type { get; set; }

    public bool cstc_only_national_currency { get; set; }

    public int? cstc_cashier_action { get; set; }

    public int? cstc_cashier_container { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cstc_cashier_btn_group { get; set; }

    public bool cstc_enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal cstc_price_factor { get; set; }
}
