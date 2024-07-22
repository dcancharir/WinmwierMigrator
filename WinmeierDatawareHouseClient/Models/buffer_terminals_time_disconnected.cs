using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("bttd_site_id", "bttd_terminal_id", "bttd_working_day")]
[Table("buffer_terminals_time_disconnected")]
public partial class buffer_terminals_time_disconnected
{
    [Key]
    public long bttd_site_id { get; set; }

    [Key]
    public int bttd_terminal_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime bttd_working_day { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bttd_timestamp { get; set; }
}
