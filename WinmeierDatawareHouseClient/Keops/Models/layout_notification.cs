using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class layout_notification
{
    [Key]
    public Guid ln_id { get; set; }

    public int ln_user_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ln_widget_type { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ln_created { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ln_user_left { get; set; }

    [Unicode(false)]
    public string? ln_data { get; set; }
}
