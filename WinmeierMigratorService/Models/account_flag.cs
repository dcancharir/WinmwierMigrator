using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("af_account_id", Name = "IX_account_flags_af_account_id")]
[Index("af_flag_id", "af_status", Name = "IX_af_flag_status")]
[Index("af_status", "af_account_id", "af_flag_id", Name = "IX_af_status_account")]
public partial class account_flag
{
    [Key]
    public long af_unique_id { get; set; }

    public long af_account_id { get; set; }

    public long af_flag_id { get; set; }

    public int af_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime af_valid_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? af_valid_to { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime af_added_datetime { get; set; }

    public int? af_added_by_user_id { get; set; }

    public long? af_added_by_promotion_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? af_cancelled_datetime { get; set; }

    public int? af_cancelled_user_id { get; set; }
}
