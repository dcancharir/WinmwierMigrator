using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class whitelist_ipv4_address
{
    public long wa_id { get; set; }

    [StringLength(30)]
    public string wa_ipv4_address { get; set; } = null!;

    [StringLength(200)]
    public string wa_description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime wa_enabled_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wa_enabled_to { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime wa_added_datetime { get; set; }
}
