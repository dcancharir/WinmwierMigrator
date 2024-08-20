using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("blacklist_rules_description")]
public partial class blacklist_rules_description
{
    [Key]
    public int brd_id { get; set; }

    [StringLength(50)]
    public string? brd_name { get; set; }

    [StringLength(50)]
    public string? brd_description { get; set; }

    public bool brd_status { get; set; }

    public int brd_minimum_fields { get; set; }
}
