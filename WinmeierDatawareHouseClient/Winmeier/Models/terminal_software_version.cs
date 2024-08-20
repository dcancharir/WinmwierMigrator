using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("tsv_client_id", "tsv_build_id", "tsv_terminal_type")]
public partial class terminal_software_version
{
    [Key]
    public short tsv_client_id { get; set; }

    [Key]
    public short tsv_build_id { get; set; }

    [Key]
    public short tsv_terminal_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tsv_insertion_date { get; set; }
}
