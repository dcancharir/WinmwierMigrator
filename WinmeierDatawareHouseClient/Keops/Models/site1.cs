using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("sites")]
public partial class site1
{
    [Key]
    public int st_site_id { get; set; }

    [StringLength(50)]
    public string st_name { get; set; } = null!;

    public int st_operator_id { get; set; }

    public int st_state { get; set; }

    [StringLength(50)]
    public string? st_ip_address { get; set; }

    public int? st_rdp_port { get; set; }

    [StringLength(50)]
    public string? st_last_known_ip { get; set; }

    [Column(TypeName = "xml")]
    public string? st_connection_string { get; set; }

    public bool? st_elp { get; set; }

    [StringLength(255)]
    public string? st_inhouse_api_url { get; set; }

    public int? st_wkrp_port { get; set; }

    public int? st_external_cashier_port { get; set; }

    public int? st_external_site_id { get; set; }

    [StringLength(10)]
    public string? st_loteria_ba_site_license { get; set; }
}
