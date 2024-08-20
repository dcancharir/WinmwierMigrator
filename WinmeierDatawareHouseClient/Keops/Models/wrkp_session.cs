using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wrkp_session
{
    public long ws_session_id { get; set; }

    public int ws_kiosk_id { get; set; }

    public long ws_cashier_session_id { get; set; }

    public int ws_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ws_opening_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ws_closed_date { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_initial_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_final_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_collected_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_withdrawals_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_deposits_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_money_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_money_out { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_tickets_created_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_tickets_inserted_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_tickets_swap_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_account_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ws_account_out { get; set; }
}
