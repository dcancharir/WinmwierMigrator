using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("external_validation_operation")]
public partial class external_validation_operation
{
    [Key]
    public long evo_id { get; set; }

    public long evo_operation_id { get; set; }

    public long evo_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal evo_net_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal evo_gross_amount { get; set; }

    public int? evo_operation_type { get; set; }

    public int? evo_business_line_type { get; set; }

    public int? evo_site_id { get; set; }

    [StringLength(200)]
    public string? evo_authorization_code { get; set; }

    [StringLength(200)]
    public string? evo_transaction_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime evo_created_date { get; set; }

    public int evo_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? evo_updated_date { get; set; }

    [StringLength(10)]
    public string? evo_register_error_code { get; set; }

    [StringLength(300)]
    public string? evo_register_error_description { get; set; }

    [Column(TypeName = "money")]
    public decimal? evo_net_amount_split_a { get; set; }

    [Column(TypeName = "money")]
    public decimal? evo_net_amount_split_b { get; set; }

    [Column(TypeName = "money")]
    public decimal? evo_bankcheck_amount { get; set; }

    [StringLength(50)]
    public string? evo_bankcheck_number { get; set; }
}
