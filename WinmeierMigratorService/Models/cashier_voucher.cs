using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("cv_operation_id", "cv_datetime", Name = "IX_cv_operation_id_datetime")]
[Index("cv_datetime", "cv_type", Name = "IX_datetime")]
[Index("cv_operation_id", Name = "IX_operation_id")]
[Index("cv_session_id", Name = "IX_session_id")]
public partial class cashier_voucher
{
    [Key]
    public long cv_voucher_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cv_datetime { get; set; }

    public long? cv_session_id { get; set; }

    public int? cv_user_id { get; set; }

    public int? cv_cashier_id { get; set; }

    [StringLength(50)]
    public string? cv_user_name { get; set; }

    [StringLength(50)]
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

    [ForeignKey("cv_session_id")]
    [InverseProperty("cashier_vouchers")]
    public virtual cashier_session? cv_session { get; set; }
}
