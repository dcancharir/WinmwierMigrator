using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class terminal_sas_meters_msg_value
{
    [Key]
    public Guid tsmmv_values_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmmv_last_referenced { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tsmmv_created { get; set; }

    public string tsmmv_values { get; set; } = null!;
}
