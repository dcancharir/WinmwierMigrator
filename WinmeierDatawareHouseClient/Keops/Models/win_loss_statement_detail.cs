using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class win_loss_statement_detail
{
    public int wlsd_id { get; set; }

    public long wlsd_win_loss_statement_id { get; set; }

    public long wlsd_account_id { get; set; }

    public int wlsd_site_id { get; set; }

    [StringLength(50)]
    public string wlsd_site_name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal wlsd_coin_in { get; set; }

    [Column(TypeName = "money")]
    public decimal wlsd_coin_out { get; set; }

    [Column(TypeName = "money")]
    public decimal wlsd_jackpot { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wlsd_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wlsd_date_to { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wsld_request_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wsld_generation_date { get; set; }

    public int? wlsd_status { get; set; }

    public int? wlsd_request_user_id { get; set; }

    public int? wlsd_print_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wlsd_print_datetime { get; set; }

    public bool? wlsd_print { get; set; }

    public bool? wlsd_iscustom { get; set; }

    public long? wlsd_document_id { get; set; }
}
