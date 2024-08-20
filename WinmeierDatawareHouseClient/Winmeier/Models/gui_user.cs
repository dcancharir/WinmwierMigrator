using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("gu_profile_id", Name = "IX_gui_users_gu_profile_id")]
[Index("gu_username", Name = "UNQ_gui_users", IsUnique = true)]
public partial class gui_user
{
    [Key]
    public int gu_user_id { get; set; }

    public int gu_profile_id { get; set; }

    [StringLength(50)]
    public string gu_username { get; set; } = null!;

    public bool gu_enabled { get; set; }

    [MaxLength(40)]
    public byte[] gu_password { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime gu_not_valid_before { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gu_not_valid_after { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gu_last_changed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gu_password_exp { get; set; }

    public bool gu_pwd_chg_req { get; set; }

    public int? gu_login_failures { get; set; }

    [MaxLength(40)]
    public byte[]? gu_password_h1 { get; set; }

    [MaxLength(40)]
    public byte[]? gu_password_h2 { get; set; }

    [MaxLength(40)]
    public byte[]? gu_password_h3 { get; set; }

    [MaxLength(40)]
    public byte[]? gu_password_h4 { get; set; }

    [MaxLength(40)]
    public byte[]? gu_password_h5 { get; set; }

    [StringLength(50)]
    public string? gu_full_name { get; set; }

    public byte[]? gu_timestamp { get; set; }

    /// <summary>
    /// 0 - USER, 1 - SYSTEM, 10 - SUPERUSER
    /// </summary>
    public short gu_user_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gu_logged_in { get; set; }

    [StringLength(50)]
    public string? gu_logon_computer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gu_last_activity { get; set; }

    [StringLength(50)]
    public string? gu_last_action { get; set; }

    public short? gu_exit_code { get; set; }

    [Column(TypeName = "money")]
    public decimal? gu_sales_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? gu_mb_sales_limit { get; set; }

    public int gu_block_reason { get; set; }

    public int? gu_master_id { get; set; }

    public long? gu_master_sequence_id { get; set; }

    [StringLength(40)]
    public string? gu_employee_code { get; set; }

    [Column(TypeName = "xml")]
    public string? gu_gui_last_login { get; set; }

    [Column(TypeName = "xml")]
    public string? gu_cashier_last_login { get; set; }
}
