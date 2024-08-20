using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("cage_concept_movement_detail")]
public partial class cage_concept_movement_detail
{
    public long ccmd_cage_concept_movement_detail_id { get; set; }

    public long ccmd_movement_id { get; set; }

    [Column(TypeName = "money")]
    public decimal ccmd_value { get; set; }

    [StringLength(6)]
    public string ccmd_iso_code { get; set; } = null!;

    public long ccmd_concept_id { get; set; }

    public int ccmd_cage_currency_type { get; set; }

    public long? CCMD_SOURCETARGET_ID { get; set; }

    public int? CCMD_CANCEL_TYPE { get; set; }
}
