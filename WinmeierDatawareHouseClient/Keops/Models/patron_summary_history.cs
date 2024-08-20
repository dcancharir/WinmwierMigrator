using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("psh_site_id", "psh_patron_id", "psh_gaming_day")]
[Table("patron_summary_history")]
public partial class patron_summary_history
{
    [Key]
    public int psh_site_id { get; set; }

    [Key]
    public long psh_patron_id { get; set; }

    [Key]
    public DateOnly psh_gaming_day { get; set; }

    [Column(TypeName = "money")]
    public decimal? psh_theo_win_egm { get; set; }

    [Column(TypeName = "money")]
    public decimal? psh_theo_win_gt { get; set; }

    public byte[] psh_timestamp { get; set; } = null!;
}
