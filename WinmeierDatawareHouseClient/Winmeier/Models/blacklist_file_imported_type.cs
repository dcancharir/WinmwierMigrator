using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("blacklist_file_imported_type")]
public partial class blacklist_file_imported_type
{
    [Key]
    public int bklt_id_type { get; set; }

    [StringLength(50)]
    public string bklt_name { get; set; } = null!;

    [StringLength(50)]
    public string bklt_message { get; set; } = null!;

    public bool bklt_entrance_allowed { get; set; }
}
