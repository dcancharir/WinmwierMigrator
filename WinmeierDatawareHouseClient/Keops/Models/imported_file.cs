using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class imported_file
{
    public long if_id { get; set; }

    [StringLength(200)]
    public string if_name { get; set; } = null!;

    public int if_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime if_import_datetime { get; set; }

    [MaxLength(1)]
    public byte[] if_file_content { get; set; } = null!;
}
