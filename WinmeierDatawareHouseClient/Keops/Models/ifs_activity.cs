using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("ifs_activity")]
public partial class ifs_activity
{
    public long ifs_id { get; set; }

    public int ifs_filetype { get; set; }

    public int? ifs_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ifs_generationdate { get; set; }

    public DateOnly ifs_reportingdate { get; set; }

    public int ifs_status { get; set; }

    [Unicode(false)]
    public string? ifs_filepath { get; set; }

    [Unicode(false)]
    public string? ifs_filename { get; set; }

    public int ifs_generationtype { get; set; }
}
