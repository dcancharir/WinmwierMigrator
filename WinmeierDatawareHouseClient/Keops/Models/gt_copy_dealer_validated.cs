using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gtcd_gaming_table_session_id", "gtcd_ticket_id")]
[Table("gt_copy_dealer_validated")]
[Index("gtcd_ticket_id", Name = "IX_gtcdv_unique_ticket_id", IsUnique = true)]
public partial class gt_copy_dealer_validated
{
    [Key]
    public long gtcd_gaming_table_session_id { get; set; }

    [Key]
    public long gtcd_ticket_id { get; set; }

    public int gtcd_validation_source { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtcd_validation_datetime { get; set; }
}
