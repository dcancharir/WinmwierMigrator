using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("mailing_programming")]
public partial class mailing_programming
{
    public long mp_prog_id { get; set; }

    [StringLength(100)]
    public string mp_name { get; set; } = null!;

    public bool mp_enabled { get; set; }

    public int mp_type { get; set; }

    [StringLength(1000)]
    public string mp_address_list { get; set; } = null!;

    [StringLength(400)]
    public string mp_subject { get; set; } = null!;

    public int mp_schedule_weekday { get; set; }

    public int mp_schedule_time_from { get; set; }

    public int mp_schedule_time_to { get; set; }

    public int mp_schedule_time_step { get; set; }
}
