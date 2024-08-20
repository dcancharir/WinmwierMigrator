using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gpsd_play_session_id", "gpsd_user_id", "gpsd_start")]
[Table("gt_play_sessions_by_dealer")]
[Index("gpsd_play_session_id", Name = "IX_gpsd_playingsessionid_userid_start", AllDescending = true)]
[Index("gpsd_user_id", Name = "IX_gt_play_sessions_by_dealer_gpsd_user_id")]
public partial class gt_play_sessions_by_dealer
{
    [Key]
    public long gpsd_play_session_id { get; set; }

    [Key]
    public int gpsd_user_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime gpsd_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gpsd_finish { get; set; }

    [Column(TypeName = "money")]
    public decimal? gpsd_buy_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? gpsd_chips_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? gpsd_netwin { get; set; }

    public long? gpsd_plays { get; set; }
}
