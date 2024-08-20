using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("gt_sessions_conciliate")]
public partial class gt_sessions_conciliate
{
    [Key]
    public long gtsc_session_id { get; set; }

    public int gtsc_type { get; set; }

    [Column(TypeName = "xml")]
    public string gtsc_data { get; set; } = null!;

    public int gtsc_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtsc_created { get; set; }
}
