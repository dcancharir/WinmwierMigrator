using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class c2_card
{
    [Key]
    [StringLength(20)]
    public string c2c_card_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? c2c_request_time { get; set; }

    public int? c2c_terminal_id { get; set; }

    [Column(TypeName = "xml")]
    public string c2c_contents { get; set; } = null!;
}
