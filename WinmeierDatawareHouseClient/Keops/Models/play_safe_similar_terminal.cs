using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("play_safe.similar_terminals")]
[Index("psst_terminal_id", Name = "IX_psst_terminal_id")]
public partial class play_safe_similar_terminal
{
    [Key]
    public long psst_id { get; set; }

    public int psst_terminal_id { get; set; }

    public int psst_similar_tid { get; set; }

    public bool? psst_manual { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime psst_created { get; set; }
}
