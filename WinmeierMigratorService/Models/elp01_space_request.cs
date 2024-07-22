using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("es_account_id", "es_transaction_id")]
public partial class elp01_space_request
{
    [Key]
    public long es_account_id { get; set; }

    [Key]
    [StringLength(50)]
    public string es_transaction_id { get; set; } = null!;

    public int es_credit_type { get; set; }

    [Column(TypeName = "money")]
    public decimal es_amount { get; set; }

    public int es_group_id { get; set; }

    public byte[] es_timestamp { get; set; } = null!;
}
