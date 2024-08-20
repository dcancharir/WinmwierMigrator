using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class settlement
{
    public long se_settlement_id { get; set; }

    public int se_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? se_created_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime se_pending_settlement_hour_calculated { get; set; }

    public int se_venue_id { get; set; }

    [StringLength(200)]
    public string? se_equipment { get; set; }

    public int? se_collector_user_id { get; set; }

    public long? se_collector_session_id { get; set; }

    public int se_venue_user_id { get; set; }

    public long se_venue_session_id { get; set; }

    public int? se_machines_collected { get; set; }

    public int? se_made_collections { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_amount_collected { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_tickets_compensate { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_tickets_issued { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_tickets_expired { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_advance_payment { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_down_payment { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_transfer_venue { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_netwin_egms { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_netwin_egms_accumulated { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_netwin_egms_venue { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_netwin_egms_accumulated_venue { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_max_netwin_egms_accumulated_venue { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_netwin_payment_venue { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_netwin_payment_accumulated_venue { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_total_settlement { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_rounding { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? se_calculation_timestamp { get; set; }

    public int? se_origin { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_expected_amount_calculated { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_expected_amount_closing { get; set; }

    [Column(TypeName = "money")]
    public decimal? se_accumulated_rounding { get; set; }
}
