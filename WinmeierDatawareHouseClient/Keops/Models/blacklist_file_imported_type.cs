using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("blacklist_file_imported_type")]
[Index("bklt_list_system", "bklt_id_type", Name = "IX_blacklist_file_imported_type_system")]
public partial class blacklist_file_imported_type
{
    [Key]
    public int bklt_id_type { get; set; }

    [StringLength(50)]
    public string bklt_name { get; set; } = null!;

    [StringLength(50)]
    public string bklt_message { get; set; } = null!;

    public bool bklt_entrance_allowed { get; set; }

    public bool? bklt_list_system { get; set; }

    public int? bklt_list_type { get; set; }

    [StringLength(20)]
    public string? bklt_doct_type { get; set; }

    [Unicode(false)]
    public string? bklt_xml { get; set; }

    [StringLength(50)]
    public string? bklt_file_identifier_import { get; set; }
}
