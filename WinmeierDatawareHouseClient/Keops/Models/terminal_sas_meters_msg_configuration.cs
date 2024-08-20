using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("terminal_sas_meters_msg_configuration")]
public partial class terminal_sas_meters_msg_configuration
{
    [Key]
    public Guid tsmmc_config_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmmc_last_referenced { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmmc_created { get; set; }

    public int tsmmc_terminal_id { get; set; }

    public int tsmmc_game_id { get; set; }

    public int tsmmc_denomination_id { get; set; }

    public string tsmmc_config { get; set; } = null!;
}
