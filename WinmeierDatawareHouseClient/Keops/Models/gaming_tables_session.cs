using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gaming_tables_session
{
    public long gts_gaming_table_session_id { get; set; }

    public int gts_gaming_table_id { get; set; }

    public long gts_cashier_session_id { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_fills_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_credits_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_own_sales_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_external_sales_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_own_purchase_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_external_purchase_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_collected_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_tips { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal gts_client_visits { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_total_sales_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_total_purchase_amount { get; set; }

    public long? gts_last_external_sale_session_id { get; set; }

    public long? gts_last_external_purchase_session_id { get; set; }

    public bool gts_pre_closing { get; set; }

    public bool gts_dropbox_enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_collected_dropbox_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_collected_dropbox_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_collected_dropbox_tickets_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_initial_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_final_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_copy_dealer_validated_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_actual_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_actual_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_actual_credit_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gts_deposits_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gts_tax { get; set; }

    public int? GTS_USER_ID { get; set; }
}
