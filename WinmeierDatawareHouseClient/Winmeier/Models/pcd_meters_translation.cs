using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("pmt_configuration_id", "pmt_pcd_io_type", "pmt_egm_number")]
[Table("pcd_meters_translation")]
public partial class pcd_meters_translation
{
    [Key]
    public long pmt_configuration_id { get; set; }

    [Key]
    public int pmt_pcd_io_type { get; set; }

    [Key]
    public long pmt_egm_number { get; set; }

    public int pmt_pcd_io_number { get; set; }

    [Column(TypeName = "money")]
    public decimal? pmt_egm_number_multiplier { get; set; }

    public int? pmt_ouput_time_pulse_down { get; set; }

    public int? pmt_ouput_time_pulse_up { get; set; }
}
