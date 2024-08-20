using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Table("countr")]
public partial class countr
{
    [Key]
    public int cr_countr_id { get; set; }

    public int cr_code { get; set; }

    [StringLength(50)]
    public string cr_name { get; set; } = null!;

    [StringLength(250)]
    public string? cr_description { get; set; }

    [StringLength(50)]
    public string? cr_provider { get; set; }

    public int? cr_area_id { get; set; }

    public int? cr_bank_id { get; set; }

    [StringLength(20)]
    public string? cr_floor_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? cr_max_payment { get; set; }

    [Column(TypeName = "money")]
    public decimal? cr_min_payment { get; set; }

    [StringLength(3)]
    public string? cr_current_isocode { get; set; }

    public bool cr_enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cr_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cr_last_modified { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cr_retirement_date { get; set; }

    public long? cr_retirement_user_id { get; set; }

    [StringLength(20)]
    public string? cr_ip_address { get; set; }

    public int? cr_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cr_last_connection { get; set; }

    public bool cr_show_log { get; set; }

    public bool cr_create_ticket { get; set; }
}
