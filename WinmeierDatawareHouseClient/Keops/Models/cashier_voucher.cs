using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class cashier_voucher
{
    public long cv_voucher_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cv_datetime { get; set; }

    public long? cv_session_id { get; set; }

    public int? cv_user_id { get; set; }

    public int? cv_cashier_id { get; set; }

    [StringLength(100)]
    public string? cv_user_name { get; set; }

    [StringLength(100)]
    public string? cv_cashier_name { get; set; }

    public string? cv_html { get; set; }

    public int cv_type { get; set; }

    [Column(TypeName = "money")]
    public decimal cv_amount { get; set; }

    public long? cv_account_id { get; set; }

    public long? cv_operation_id { get; set; }

    public long? cv_sequence { get; set; }

    public int? cv_mode { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_dev { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_base { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_tax1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_tax2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_final { get; set; }

    public long? cv_m01_cancelled_sequence { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_tax3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_tax4 { get; set; }

    [Column(TypeName = "money")]
    public decimal? cv_m01_tax5 { get; set; }

    public int? cv_venue_id { get; set; }
}
