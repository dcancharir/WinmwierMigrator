using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("jcm_jackpot_id", "jcm_type")]
public partial class jackpots_contribution_meter
{
    [Key]
    public int jcm_jackpot_id { get; set; }

    [Key]
    public int jcm_type { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal jcm_amount { get; set; }
}
