using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("t3gs_vendor_id", "t3gs_serial_number")]
[Index("t3gs_vendor_id", "t3gs_machine_number", Name = "IX_3gs_vendor_serialnumber", IsUnique = true)]
public partial class terminals_3g
{
    [Key]
    [StringLength(50)]
    public string t3gs_vendor_id { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string t3gs_serial_number { get; set; } = null!;

    public int t3gs_machine_number { get; set; }

    public int? t3gs_terminal_id { get; set; }
}
