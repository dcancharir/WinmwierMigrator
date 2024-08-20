using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class operations_after_hour
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime oah_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? oah_to { get; set; }

    public long oah_event_type { get; set; }

    public long oah_event_type_sent { get; set; }

    public int oah_changes { get; set; }

    public int oah_changes_sent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? oah_last_checked { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? oah_first_event_detected { get; set; }
}
