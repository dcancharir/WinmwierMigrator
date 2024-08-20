using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("sales_interface")]
[Index("si_frame", "si_sequence", Name = "PK_sales_interface", IsUnique = true)]
public partial class sales_interface
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime si_frame { get; set; }

    public long si_sequence { get; set; }

    [Column(TypeName = "money")]
    public decimal si_wagers { get; set; }

    [Column(TypeName = "money")]
    public decimal si_payouts { get; set; }

    public int si_status { get; set; }

    public int si_num_retries { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? si_last_timestamp_sending { get; set; }
}
