using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("winstats_summary_status_history")]
public partial class winstats_summary_status_history
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wssh_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wssh_lastupdateddate { get; set; }
}
