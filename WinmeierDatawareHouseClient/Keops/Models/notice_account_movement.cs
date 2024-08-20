using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("notice_account_movement")]
[Index("mn_notice_code", Name = "IX_notice_account_movement_mn_notice_code")]
public partial class notice_account_movement
{
    [Key]
    public long mn_movement_notice_id { get; set; }

    public long mn_movement_id { get; set; }

    public int mn_notice_code { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string mn_operation_type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime mn_date { get; set; }
}
