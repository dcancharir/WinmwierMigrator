using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class bank_account
{
    [Key]
    public int ba_account_id { get; set; }

    [StringLength(50)]
    public string ba_bank_name { get; set; } = null!;

    [StringLength(50)]
    public string ba_description { get; set; } = null!;

    [StringLength(50)]
    public string ba_customer_number { get; set; } = null!;

    [StringLength(50)]
    public string ba_account_number { get; set; } = null!;

    [StringLength(50)]
    public string ba_effective_days { get; set; } = null!;

    [StringLength(50)]
    public string ba_method_payment { get; set; } = null!;

    public bool ba_enabled { get; set; }
}
