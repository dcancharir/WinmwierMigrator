using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cd_site_id", "cd_draw_id")]
[Index("cd_account_id", "cd_draw_datetime", Name = "IX_cd_account_datetime")]
[Index("cd_draw_datetime", Name = "IX_cd_datetime")]
[Index("cd_draw_id", "cd_draw_datetime", "cd_account_id", Name = "IX_cd_draw_datetime_account")]
[Index("cd_upload_to_ext_db", Name = "IX_cd_upload")]
public partial class cashdesk_draw
{
    [Key]
    public int cd_site_id { get; set; }

    [Key]
    public long cd_draw_id { get; set; }

    public long cd_operation_id { get; set; }

    public long cd_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cd_draw_datetime { get; set; }

    [StringLength(500)]
    public string cd_combination_bet { get; set; } = null!;

    [StringLength(500)]
    public string cd_combination_won { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? cd_re_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal? cd_nr_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal? cd_re_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? cd_nr_won { get; set; }

    public long? cd_prize_id { get; set; }

    public int? cd_upload_to_ext_db { get; set; }

    public int? cd_terminal { get; set; }

    public int? cd_session_id { get; set; }
}
