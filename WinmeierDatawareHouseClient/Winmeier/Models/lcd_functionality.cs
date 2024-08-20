using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class lcd_functionality
{
    [Key]
    public int fun_function_id { get; set; }

    [StringLength(50)]
    public string fun_name { get; set; } = null!;

    public int fun_enabled { get; set; }
}
