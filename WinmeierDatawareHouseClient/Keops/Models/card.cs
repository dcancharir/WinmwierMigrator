using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ca_trackdata", "ca_linked_type")]
[Index("ca_linked_type", "ca_linked_id", Name = "IX_ca_linked_type_id_trackdata")]
public partial class card
{
    [Key]
    [StringLength(50)]
    public string ca_trackdata { get; set; } = null!;

    [Key]
    public int ca_linked_type { get; set; }

    public long? ca_linked_id { get; set; }

    public int ca_block_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ca_block_datetime { get; set; }

    public int ca_pin_flags { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ca_pin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ca_pin_changed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ca_pin_expires { get; set; }

    public int ca_pin_errors { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ca_payment_datetime { get; set; }

    [Column(TypeName = "money")]
    public decimal? ca_total_paid { get; set; }

    [Column(TypeName = "money")]
    public decimal? ca_refundable_deposit { get; set; }
}
