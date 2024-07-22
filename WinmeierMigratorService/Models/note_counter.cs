using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class note_counter
{
    [Key]
    public long nc_application_id { get; set; }

    public int nc_model { get; set; }

    public int nc_communication_type { get; set; }

    public int? nc_port { get; set; }

    public int? nc_parity { get; set; }

    public int? nc_data_bits { get; set; }

    public int? nc_stop_bits { get; set; }

    public int? nc_baud_rate { get; set; }

    [Column(TypeName = "xml")]
    public string? nc_denominations { get; set; }

    [StringLength(3)]
    public string nc_currency_iso_code { get; set; } = null!;
}
