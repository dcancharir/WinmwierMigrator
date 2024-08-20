using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("terminal_sas_meters_history_info")]
public partial class terminal_sas_meters_history_info
{
    [Column(TypeName = "datetime")]
    public DateTime? tsmhi_datetime { get; set; }
}
