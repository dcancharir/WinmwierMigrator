using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("lr_scene_id", "lr_date")]
[Table("layout_recording")]
[Index("lr_date", Name = "XI_layout_recording_date")]
public partial class layout_recording
{
    [Key]
    public int lr_scene_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime lr_date { get; set; }

    public int lr_floor { get; set; }

    [Unicode(false)]
    public string lr_json { get; set; } = null!;
}
