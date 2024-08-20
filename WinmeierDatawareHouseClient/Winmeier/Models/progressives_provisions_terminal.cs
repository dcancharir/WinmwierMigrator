using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("ppt_provision_id", "ppt_terminal_id")]
public partial class progressives_provisions_terminal
{
    [Key]
    public long ppt_provision_id { get; set; }

    [Key]
    public int ppt_terminal_id { get; set; }

    public long ppt_progressive_id { get; set; }

    [Column(TypeName = "money")]
    public decimal ppt_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ppt_diff_amount { get; set; }
}
