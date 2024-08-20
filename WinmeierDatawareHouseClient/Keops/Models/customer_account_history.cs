using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cah_account_id", "cah_created", "cah_auto_id")]
[Table("customer_account_history")]
public partial class customer_account_history
{
    [Key]
    public long cah_account_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime cah_created { get; set; }

    [Key]
    public long cah_auto_id { get; set; }

    [StringLength(50)]
    public string cah_opcode_text { get; set; } = null!;

    public long? cah_customer_id { get; set; }

    [StringLength(256)]
    public string? cah_opcode_data { get; set; }
}
