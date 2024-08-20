using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("x2d_date", "x2d_weekday", "x2d_id", "x2d_meter_id", "x2d_meter_item")]
[Table("h_w2d_tmh")]
public partial class h_w2d_tmh
{
    [Key]
    public int x2d_date { get; set; }

    [Key]
    public byte x2d_weekday { get; set; }

    [Key]
    public int x2d_id { get; set; }

    [Key]
    public int x2d_meter_id { get; set; }

    [Key]
    public int x2d_meter_item { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_00_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_00_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_00_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_00_avg { get; set; }

    public long? x2d_00_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_01_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_01_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_01_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_01_avg { get; set; }

    public long? x2d_01_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_02_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_02_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_02_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_02_avg { get; set; }

    public long? x2d_02_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_03_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_03_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_03_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_03_avg { get; set; }

    public long? x2d_03_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_04_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_04_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_04_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_04_avg { get; set; }

    public long? x2d_04_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_05_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_05_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_05_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_05_avg { get; set; }

    public long? x2d_05_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_06_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_06_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_06_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_06_avg { get; set; }

    public long? x2d_06_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_07_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_07_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_07_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_07_avg { get; set; }

    public long? x2d_07_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_08_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_08_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_08_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_08_avg { get; set; }

    public long? x2d_08_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_09_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_09_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_09_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_09_avg { get; set; }

    public long? x2d_09_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_10_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_10_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_10_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_10_avg { get; set; }

    public long? x2d_10_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_11_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_11_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_11_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_11_avg { get; set; }

    public long? x2d_11_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_12_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_12_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_12_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_12_avg { get; set; }

    public long? x2d_12_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_13_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_13_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_13_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_13_avg { get; set; }

    public long? x2d_13_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_14_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_14_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_14_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_14_avg { get; set; }

    public long? x2d_14_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_15_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_15_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_15_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_15_avg { get; set; }

    public long? x2d_15_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_16_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_16_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_16_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_16_avg { get; set; }

    public long? x2d_16_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_17_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_17_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_17_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_17_avg { get; set; }

    public long? x2d_17_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_18_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_18_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_18_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_18_avg { get; set; }

    public long? x2d_18_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_19_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_19_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_19_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_19_avg { get; set; }

    public long? x2d_19_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_20_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_20_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_20_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_20_avg { get; set; }

    public long? x2d_20_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_21_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_21_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_21_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_21_avg { get; set; }

    public long? x2d_21_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_22_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_22_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_22_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_22_avg { get; set; }

    public long? x2d_22_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_23_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_23_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_23_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_23_avg { get; set; }

    public long? x2d_23_num { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_dd_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_dd_max { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_dd_acc { get; set; }

    [Column(TypeName = "money")]
    public decimal? x2d_dd_avg { get; set; }

    public long? x2d_dd_num { get; set; }
}
