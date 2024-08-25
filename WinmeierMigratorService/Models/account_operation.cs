using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("ao_code", "ao_automatically_printed", "ao_datetime", Name = "IX_account_operations_code_printed_date")]
[Index("ao_code", "ao_datetime", "ao_account_id", Name = "IX_ao_code_date_account")]
[Index("ao_datetime", "ao_account_id", "ao_promo_id", Name = "IX_ao_date_account_promo")]
[Index("ao_cashier_session_id", "ao_datetime", Name = "IX_ao_session_id_date")]
public partial class account_operation
{
    [Key]
    public long ao_operation_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ao_datetime { get; set; }

    public int ao_code { get; set; }

    public long ao_account_id { get; set; }

    public long? ao_cashier_session_id { get; set; }

    public long? ao_mb_account_id { get; set; }

    public long? ao_promo_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? ao_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ao_non_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal? ao_won_lock { get; set; }

    public long? ao_operation_data { get; set; }

    public bool ao_automatically_printed { get; set; }

    [Column(TypeName = "money")]
    public decimal? ao_non_redeemable2 { get; set; }

    [Column(TypeName = "money")]
    public decimal ao_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal ao_promo_redeemable { get; set; }

    [Column(TypeName = "money")]
    public decimal ao_promo_not_redeemable { get; set; }

    public long? ao_user_id { get; set; }

    public int? ao_undo_status { get; set; }

    public long? ao_undo_operation_id { get; set; }

    public long? ao_reason_id { get; set; }

    [StringLength(250)]
    public string? ao_comment { get; set; }

    [StringLength(255)]
    public string? ao_comment_handpay { get; set; }
}
