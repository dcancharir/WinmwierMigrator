using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("mobibank_device_bank")]
public partial class mobibank_device_bank
{
    public int mdb_id { get; set; }

    public int mdb_bank_id { get; set; }

    [StringLength(2000)]
    public string? mdb_name { get; set; }

    public int? mdb_device_id { get; set; }
}
