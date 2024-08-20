using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class intouch_help_page
{
    public int ih_id { get; set; }

    [StringLength(100)]
    public string ih_controller { get; set; } = null!;

    [StringLength(100)]
    public string ih_view { get; set; } = null!;

    [StringLength(300)]
    public string? ih_message_line_1 { get; set; }

    [StringLength(300)]
    public string? ih_message_line_2 { get; set; }

    [StringLength(300)]
    public string? ih_message_line_3 { get; set; }

    public int ih_language_id { get; set; }

    public bool ih_status { get; set; }
}
