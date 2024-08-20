using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tsv_terminal_type", "tsv_version")]
public partial class terminal_software_version
{
    [Key]
    public short tsv_terminal_type { get; set; }

    [Key]
    [StringLength(50)]
    public string tsv_version { get; set; } = null!;

    public short tsv_client_id { get; set; }

    public short tsv_build_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tsv_insertion_date { get; set; }
}
