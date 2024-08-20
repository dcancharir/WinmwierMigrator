using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class gui_user_venue
{
    [Key]
    public long guv_user_id { get; set; }

    [Column(TypeName = "xml")]
    public string? guv_venues { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? guv_last_modified { get; set; }

    public bool? guv_is_collector { get; set; }

    public bool GUV_IS_GLOBAL_ADMIN { get; set; }
}
