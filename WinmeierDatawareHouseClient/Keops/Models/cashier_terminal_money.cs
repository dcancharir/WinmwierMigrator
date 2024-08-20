using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ctm_session_id", "ctm_terminal_id", "ctm_denomination")]
[Table("cashier_terminal_money")]
[Index("ctm_money_collection_id", Name = "IX_ctm_money_collection_id")]
public partial class cashier_terminal_money
{
    [Key]
    public long ctm_session_id { get; set; }

    [Key]
    public int ctm_terminal_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal ctm_denomination { get; set; }

    public int ctm_quantity { get; set; }

    public long ctm_money_collection_id { get; set; }
}
