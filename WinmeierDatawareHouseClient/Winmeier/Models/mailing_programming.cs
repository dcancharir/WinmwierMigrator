using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("mailing_programming")]
public partial class mailing_programming
{
    [Key]
    public long mp_prog_id { get; set; }

    [StringLength(50)]
    public string mp_name { get; set; } = null!;

    public bool mp_enabled { get; set; }

    public int mp_type { get; set; }

    [StringLength(500)]
    public string mp_address_list { get; set; } = null!;

    [StringLength(200)]
    public string mp_subject { get; set; } = null!;

    public int mp_schedule_weekday { get; set; }

    public int mp_schedule_time_from { get; set; }

    public int mp_schedule_time_to { get; set; }

    public int mp_schedule_time_step { get; set; }
}
