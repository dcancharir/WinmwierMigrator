using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("lcd_package")]
public partial class lcd_package
{
    [Key]
    public int LP_WPK_ID { get; set; }

    [StringLength(50)]
    public string LP_NAME { get; set; } = null!;

    public long LP_RESOURCE_ID { get; set; }

    [StringLength(250)]
    public string LP_RESOURCE_NAME { get; set; } = null!;

    [StringLength(100)]
    public string LP_EXTENSION { get; set; } = null!;

    [StringLength(250)]
    public string LP_SIGNATURE { get; set; } = null!;

    [StringLength(50)]
    public string LP_VERSION { get; set; } = null!;

    public int LP_LENGTH { get; set; }

    public byte[]? LP_DATA { get; set; }

    [MaxLength(50)]
    public byte[]? LP_HASH { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LP_LAST_UPDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LP_LAST_DEPLOY { get; set; }
}
