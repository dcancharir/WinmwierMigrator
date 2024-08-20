using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gaming_tables_tournament_enrollment")]
public partial class gaming_tables_tournament_enrollment
{
    public long gtte_enrollment_id { get; set; }

    public long gtte_tournament_id { get; set; }

    public long gtte_account_id { get; set; }

    public int gtte_status { get; set; }

    public int gtte_num_rebuys { get; set; }

    public long? gtte_operation_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gtte_last_update { get; set; }
}
