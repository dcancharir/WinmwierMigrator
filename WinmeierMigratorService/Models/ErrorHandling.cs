using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("ErrorHandling")]
public partial class ErrorHandling
{
    [Key]
    public int pkErrorHandlingID { get; set; }

    public int Error_Number { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? Error_Message { get; set; }

    public short Error_Severity { get; set; }

    public short Error_State { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Error_Procedure { get; set; } = null!;

    public int Error_Line { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string HostName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Time_Stamp { get; set; }
}
