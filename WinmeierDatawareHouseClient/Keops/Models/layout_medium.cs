using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_medium
{
    public long lm_id { get; set; }

    [MaxLength(1)]
    public byte[] lm_data { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime lm_created { get; set; }

    public int lm_user_created { get; set; }

    public int lm_type { get; set; }

    [StringLength(100)]
    public string? lm_external_id { get; set; }

    [StringLength(500)]
    public string? lm_description { get; set; }

    public int lm_media_type { get; set; }

    [MaxLength(1)]
    public byte[]? lm_data_thumbnail { get; set; }
}
