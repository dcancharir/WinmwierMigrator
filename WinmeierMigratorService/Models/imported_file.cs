using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class imported_file
{
    [Key]
    public long if_id { get; set; }

    [StringLength(100)]
    public string if_name { get; set; } = null!;

    public int if_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime if_import_datetime { get; set; }

    public byte[] if_file_content { get; set; } = null!;
}
