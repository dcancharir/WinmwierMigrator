using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("csm_cage_session_id", "csm_source_target_id", "csm_concept_id", "csm_iso_code", "csm_cage_currency_type")]
public partial class cage_session_meter
{
    [Key]
    public long csm_cage_session_id { get; set; }

    [Key]
    public long csm_source_target_id { get; set; }

    [Key]
    public long csm_concept_id { get; set; }

    [Key]
    [StringLength(3)]
    public string csm_iso_code { get; set; } = null!;

    [Key]
    public int csm_cage_currency_type { get; set; }

    [Column(TypeName = "money")]
    public decimal csm_value { get; set; }

    [Column(TypeName = "money")]
    public decimal csm_value_in { get; set; }

    [Column(TypeName = "money")]
    public decimal csm_value_out { get; set; }
}
