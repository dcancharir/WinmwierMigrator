using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class card_template
{
    public long ct_card_template_id { get; set; }

    [StringLength(100)]
    public string? ct_name { get; set; }

    [MaxLength(1)]
    public byte[]? ct_template { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ct_creation_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ct_last_update_date { get; set; }

    [StringLength(20)]
    public string? ct_file_extension { get; set; }
}
