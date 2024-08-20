using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("play_safe.terminal_processed_group")]
public partial class play_safe_terminal_processed_group
{
    [Key]
    public long psep_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime psep_datime { get; set; }

    public int psep_terminal_id { get; set; }

    public long? psep_min { get; set; }

    public long? psep_max { get; set; }

    public long? psep_r1 { get; set; }

    public long? psep_r2 { get; set; }

    public long? psep_r3 { get; set; }

    public long? psep_r4 { get; set; }

    public long? psep_r5 { get; set; }

    public long? psep_r6 { get; set; }

    public long? psep_r7 { get; set; }

    public long? psep_r8 { get; set; }

    public long? psep_r9 { get; set; }

    public short? psep_card_bits { get; set; }

    public bool? psep_cp0 { get; set; }

    public short? psep_to0 { get; set; }

    public short? psep_fs0 { get; set; }

    public bool? psep_cp1 { get; set; }

    public short? psep_to1 { get; set; }

    public short? psep_fs1 { get; set; }
}
