using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("sph_control")]
public partial class sph_control
{
    [Key]
    public long sphc_last_play_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sphc_last_update { get; set; }
}
