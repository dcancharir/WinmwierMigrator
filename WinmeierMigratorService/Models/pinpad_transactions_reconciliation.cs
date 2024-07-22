using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("ptc_drawal", "ptc_id")]
[Table("pinpad_transactions_reconciliation")]
public partial class pinpad_transactions_reconciliation
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ptc_drawal { get; set; }

    public int ptc_user_id { get; set; }

    [Key]
    public long ptc_id { get; set; }

    public bool ptc_reconciliate { get; set; }

    public bool? ptc_drawal_status { get; set; }

    public long? ptc_code { get; set; }
}
