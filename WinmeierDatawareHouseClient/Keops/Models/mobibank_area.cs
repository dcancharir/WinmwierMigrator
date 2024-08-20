using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class mobibank_area
{
    public int mba_id { get; set; }

    public int mba_account_id { get; set; }

    public int mba_bank_id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? mba_name { get; set; }
}
