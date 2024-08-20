using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ca_customer_id", "ca_account_id")]
[Index("ca_account_id", Name = "IX_ca_account_id")]
public partial class customer_account
{
    [Key]
    public long ca_customer_id { get; set; }

    [Key]
    public long ca_account_id { get; set; }
}
