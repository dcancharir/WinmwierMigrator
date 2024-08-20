using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("customers_sum_balance")]
public partial class customers_sum_balance
{
    [Key]
    public long csb_account_id_target { get; set; }

    public long csb_account_id_source1 { get; set; }

    public long csb_account_id_source2 { get; set; }

    public int csb_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? csb_sync_datetime { get; set; }

    public long? csb_ms_sequence_id { get; set; }

    public Guid? csb_ms_change_guid { get; set; }
}
