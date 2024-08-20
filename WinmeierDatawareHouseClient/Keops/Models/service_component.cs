using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class service_component
{
    [Key]
    public int sc_packet_type { get; set; }

    [StringLength(50)]
    public string sc_name { get; set; } = null!;

    [StringLength(250)]
    public string sc_location { get; set; } = null!;

    public byte sc_type { get; set; }

    public byte sc_schedule_type { get; set; }

    public TimeOnly? sc_start_hour { get; set; }

    [StringLength(250)]
    public string? sc_url_echo { get; set; }

    public bool sc_enable { get; set; }

    public bool sc_readonly { get; set; }

    public int sc_port { get; set; }

    public int sc_priority { get; set; }
}
