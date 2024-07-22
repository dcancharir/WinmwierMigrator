using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
[Table("egm_control_mark")]
public partial class egm_control_mark
{
    [Column(TypeName = "datetime")]
    public DateTime ecm_control_mark { get; set; }
}
