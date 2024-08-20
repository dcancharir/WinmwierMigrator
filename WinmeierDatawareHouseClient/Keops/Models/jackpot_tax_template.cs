using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("jackpot_tax_template")]
public partial class jackpot_tax_template
{
    [Key]
    public long jtt_id { get; set; }

    public byte[]? jtt_template { get; set; }

    [StringLength(50)]
    public string? jtt_description { get; set; }
}
