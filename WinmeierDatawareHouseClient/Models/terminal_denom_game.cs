using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("terminal_denom_game")]
public partial class terminal_denom_game
{
    [Key]
    public int tdg_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tdg_received { get; set; }

    [Column(TypeName = "xml")]
    public string tdg_data_xml { get; set; } = null!;
}
