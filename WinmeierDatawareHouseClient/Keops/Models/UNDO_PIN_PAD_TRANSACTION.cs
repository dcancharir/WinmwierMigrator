using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("UNDO_PIN_PAD_TRANSACTION")]
public partial class UNDO_PIN_PAD_TRANSACTION
{
    public int uppt_id { get; set; }

    public int uppt_pinpadmodel { get; set; }

    [StringLength(100)]
    public string? uppt_control_number { get; set; }

    [StringLength(100)]
    public string uppt_terminal_id { get; set; } = null!;

    public int uppt_cancel_retries { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime uppt_last_update { get; set; }
}
