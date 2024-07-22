using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("wls_account_id", "wls_date_from", "wls_date_to")]
[Index("wls_date_from", "wls_date_to", Name = "IX_wls_date_from_date_to")]
[Index("wls_status", "wls_request_date", Name = "IX_wls_status_request_date")]
public partial class win_loss_statement
{
    [Key]
    public long wls_account_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wls_date_from { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wls_date_to { get; set; }

    public int? wls_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wls_request_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wls_generation_date { get; set; }

    public int wls_request_user_id { get; set; }

    public int? wls_print_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wls_print_date { get; set; }

    public bool wls_print { get; set; }

    [Column(TypeName = "money")]
    public decimal wls_played_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal wls_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal wls_jackpot_amount { get; set; }

    public long? wls_document_id { get; set; }
}
