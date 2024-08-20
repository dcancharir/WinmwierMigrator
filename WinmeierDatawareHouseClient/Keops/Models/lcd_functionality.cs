using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class lcd_functionality
{
    [Key]
    public int fun_function_id { get; set; }

    [StringLength(50)]
    public string fun_name { get; set; } = null!;

    public int fun_500_enabled { get; set; }

    public bool fun_500_editable { get; set; }

    public bool fun_501_enabled { get; set; }

    public bool fun_501_editable { get; set; }

    public bool fun_545_enabled { get; set; }

    public bool fun_545_editable { get; set; }

    public bool fun_600_enabled { get; set; }

    public bool fun_600_editable { get; set; }

    public bool fun_601_enabled { get; set; }

    public bool fun_601_editable { get; set; }
}
