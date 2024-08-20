using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("live_operations_last_processed")]
public partial class live_operations_last_processed
{
    [Key]
    public int lolc_venue_id { get; set; }

    public Guid lolc_guid { get; set; }

    public DateTimeOffset lolc_datetime { get; set; }
}
