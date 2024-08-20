using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("hierarchy.tree")]
public partial class hierarchy_tree
{
    [Key]
    public Guid ht_id { get; set; }

    public Guid ht_org_id { get; set; }

    [StringLength(15)]
    public string? ht_level0_code { get; set; }

    [StringLength(15)]
    public string? ht_level1_code { get; set; }

    [StringLength(15)]
    public string? ht_level2_code { get; set; }

    [StringLength(15)]
    public string? ht_level3_code { get; set; }

    [StringLength(15)]
    public string? ht_level4_code { get; set; }

    [StringLength(15)]
    public string? ht_level5_code { get; set; }

    [StringLength(15)]
    public string? ht_level6_code { get; set; }

    [StringLength(15)]
    public string? ht_level7_code { get; set; }

    [StringLength(15)]
    public string? ht_level8_code { get; set; }

    [StringLength(15)]
    public string? ht_level9_code { get; set; }

    [StringLength(50)]
    public string? ht_level0_name { get; set; }

    [StringLength(50)]
    public string? ht_level1_name { get; set; }

    [StringLength(50)]
    public string? ht_level2_name { get; set; }

    [StringLength(50)]
    public string? ht_level3_name { get; set; }

    [StringLength(50)]
    public string? ht_level4_name { get; set; }

    [StringLength(50)]
    public string? ht_level5_name { get; set; }

    [StringLength(50)]
    public string? ht_level6_name { get; set; }

    [StringLength(50)]
    public string? ht_level7_name { get; set; }

    [StringLength(50)]
    public string? ht_level8_name { get; set; }

    [StringLength(50)]
    public string? ht_level9_name { get; set; }
}
