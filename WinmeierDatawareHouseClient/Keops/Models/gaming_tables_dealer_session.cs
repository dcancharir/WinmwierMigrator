using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gaming_tables_dealer_session
{
    public long gtds_dealer_session_id { get; set; }

    public int gtds_user_id { get; set; }

    public int gtds_gaming_table_id { get; set; }

    public int gtds_gaming_table_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtds_started { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtds_finished { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtds_fills_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtds_credits_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtds_drop_chips_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtds_fills_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtds_credits_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtds_drop_amount { get; set; }
}
