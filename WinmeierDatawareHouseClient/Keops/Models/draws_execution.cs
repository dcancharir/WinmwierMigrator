using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class draws_execution
{
    public long de_id { get; set; }

    public long de_draw_id { get; set; }

    public int de_user_id { get; set; }

    public int? de_user_id_redraw { get; set; }

    public int? de_user_id_end { get; set; }

    public int? de_total_entries { get; set; }

    public int de_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime de_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? de_datetime_redraw { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? de_datetime_end { get; set; }

    public string? de_comment { get; set; }
}
