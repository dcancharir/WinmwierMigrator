using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("pgp_created", Name = "IX_pgp_created")]
[Index("pgp_hour_to", "pgp_progressive_id", "pgp_hour_from", Name = "IX_pgp_to_progressive_from")]
public partial class progressives_provision
{
    [Key]
    public long pgp_provision_id { get; set; }

    public long pgp_progressive_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pgp_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pgp_hour_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pgp_hour_to { get; set; }

    [Column(TypeName = "money")]
    public decimal pgp_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal pgp_theoretical_amount { get; set; }

    public long? pgp_cage_session_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? pgp_cage_amount { get; set; }

    public int pgp_status { get; set; }

    public int? pgp_gui_user_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? pgp_current_amount { get; set; }
}
