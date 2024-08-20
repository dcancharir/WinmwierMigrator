using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("hpc_meter")]
public partial class hpc_meter
{
    [Key]
    public int hpc_terminal_id { get; set; }

    public long hpc_wcp_sequence_id { get; set; }

    [Column(TypeName = "money")]
    public decimal hpc_handpays_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hpc_last_reported { get; set; }

    [Column(TypeName = "money")]
    public decimal? hpc_max_handpays_amount { get; set; }
}
