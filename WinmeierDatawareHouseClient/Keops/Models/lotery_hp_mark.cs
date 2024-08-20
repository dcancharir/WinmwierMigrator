using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("lotery_hp_mark")]
public partial class lotery_hp_mark
{
    public int lhm_next_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lhm_last_hp_paid { get; set; }
}
