using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class cage_concept
{
    [Key]
    public long cc_concept_id { get; set; }

    [StringLength(50)]
    public string cc_description { get; set; } = null!;

    public bool cc_is_provision { get; set; }

    public bool cc_show_in_report { get; set; }

    [Column(TypeName = "money")]
    public decimal? cc_unit_price { get; set; }

    [StringLength(20)]
    public string cc_name { get; set; } = null!;

    public int cc_type { get; set; }

    public bool? cc_enabled { get; set; }

    public int? cc_sequence_id { get; set; }

    public int? cc_operation_code { get; set; }

    public int? cc_voucher_type { get; set; }
}
