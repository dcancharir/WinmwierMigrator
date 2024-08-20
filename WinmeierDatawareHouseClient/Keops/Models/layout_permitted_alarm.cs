using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class layout_permitted_alarm
{
    [Key]
    public int lpa_alarm_id { get; set; }

    public bool? lpa_alarm_filtered { get; set; }
}
