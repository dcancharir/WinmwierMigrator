using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("mi_prog_id", "mi_prog_date", "mi_prog_data", Name = "IX_mailing_instances", IsUnique = true)]
public partial class mailing_instance
{
    [Key]
    public long mi_mailing_instance_id { get; set; }

    public long mi_prog_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mi_prog_date { get; set; }

    /// <summary>
    /// Time in minutes (0..1439)
    /// </summary>
    public long mi_prog_data { get; set; }

    [StringLength(50)]
    public string mi_name { get; set; } = null!;

    /// <summary>
    /// 1: Statistics
    /// </summary>
    public int mi_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mi_datetime { get; set; }

    [StringLength(500)]
    public string mi_address_list { get; set; } = null!;

    [StringLength(200)]
    public string mi_subject { get; set; } = null!;

    public string mi_message { get; set; } = null!;

    /// <summary>
    /// 0: Pending; 1: Running; 2: Successful; 3: Failed
    /// </summary>
    public int mi_status { get; set; }

    [StringLength(500)]
    public string? mi_result { get; set; }
}
