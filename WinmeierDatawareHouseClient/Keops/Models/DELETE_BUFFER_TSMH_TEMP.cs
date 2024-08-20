using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("DELETE_BUFFER_TSMH_TEMP")]
public partial class DELETE_BUFFER_TSMH_TEMP
{
    public int tsmh_terminal_id { get; set; }

    public int tsmh_meter_code { get; set; }

    public int tsmh_game_id { get; set; }

    [Column(TypeName = "money")]
    public decimal tsmh_denomination { get; set; }

    public int tsmh_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tsmh_datetime { get; set; }
}
