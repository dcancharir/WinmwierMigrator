using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("df_drawing_id", "df_flag_id", "df_flag_purpose_type")]
public partial class drawing_flag
{
    [Key]
    public long df_drawing_id { get; set; }

    [Key]
    public long df_flag_id { get; set; }

    [Key]
    public int df_flag_purpose_type { get; set; }

    public int? df_flag_count { get; set; }

    public int? df_flag_count_excluded { get; set; }

    public int? df_flag_count_spend { get; set; }

    public int? df_flag_count_assign { get; set; }
}
