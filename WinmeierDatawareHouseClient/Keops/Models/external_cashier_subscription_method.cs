using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class external_cashier_subscription_method
{
    [Key]
    [StringLength(200)]
    public string ecsc_actionname { get; set; } = null!;

    public bool ecsc_enabled { get; set; }

    public string ecsc_description { get; set; } = null!;
}
