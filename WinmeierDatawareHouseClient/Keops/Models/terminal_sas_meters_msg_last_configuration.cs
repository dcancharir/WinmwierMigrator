using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tlsmmc_terminal_id", "tlsmmc_game_id", "tlsmmc_denom_id")]
[Table("terminal_sas_meters_msg_last_configuration")]
public partial class terminal_sas_meters_msg_last_configuration
{
    [Key]
    public int tlsmmc_terminal_id { get; set; }

    [Key]
    public int tlsmmc_game_id { get; set; }

    [Key]
    public int tlsmmc_denom_id { get; set; }

    public Guid tlsmmc_config_id { get; set; }

    public Guid tlsmmc_values_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tlsmmc_update_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tlsmmc_created_date { get; set; }
}
