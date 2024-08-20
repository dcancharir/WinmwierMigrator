using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class hot_seats_flag
{
    public long hsf_id { get; set; }

    public long hsf_hot_seat_id { get; set; }

    public int hsf_type { get; set; }

    public long hsf_flag_id { get; set; }

    public int hsf_flag_count { get; set; }
}
