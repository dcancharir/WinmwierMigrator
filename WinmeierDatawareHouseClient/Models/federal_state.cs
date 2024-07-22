using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class federal_state
{
    [Key]
    public int fs_state_id { get; set; }

    [StringLength(50)]
    public string fs_name { get; set; } = null!;

    [StringLength(2)]
    public string fs_country_iso_code2 { get; set; } = null!;

    public int? fs_cfdi_id { get; set; }
}
