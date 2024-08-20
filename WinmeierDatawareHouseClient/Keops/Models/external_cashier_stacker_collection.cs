using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("external_cashier_stacker_collection")]
public partial class external_cashier_stacker_collection
{
    public long ecsc__id { get; set; }

    [StringLength(50)]
    public string ecsc_guid { get; set; } = null!;

    public long ecsc_moneycollectionid { get; set; }

    public int ecsc_terminalid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ecsc_datetime { get; set; }
}
