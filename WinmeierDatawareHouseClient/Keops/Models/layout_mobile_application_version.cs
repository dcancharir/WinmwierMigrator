using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class layout_mobile_application_version
{
    public long lmav_id { get; set; }

    [StringLength(20)]
    public string lmav_version { get; set; } = null!;

    [MaxLength(1)]
    public byte[] lmav_apk { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime lmav_date { get; set; }
}
