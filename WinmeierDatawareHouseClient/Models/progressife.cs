using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("pgs_status", "pgs_name", Name = "IX_pgs_status_name")]
public partial class progressife
{
    [Key]
    public long pgs_progressive_id { get; set; }

    [StringLength(50)]
    public string pgs_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime pgs_created { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal pgs_contribution_pct { get; set; }

    public int pgs_num_levels { get; set; }

    [Column(TypeName = "money")]
    public decimal pgs_amount { get; set; }

    [Column(TypeName = "xml")]
    public string pgs_terminal_list { get; set; } = null!;

    public int pgs_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pgs_last_provisioned_hour { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pgs_status_changed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pgs_brand { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pgs_server { get; set; }

    public bool? pgs_multiseat { get; set; }
}
