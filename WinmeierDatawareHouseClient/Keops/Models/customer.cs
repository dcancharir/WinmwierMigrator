using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class customer
{
    [Key]
    public long cus_customer_id { get; set; }

    public long? cus_external_id { get; set; }

    public int? cus_status { get; set; }

    public long? cus_default_account_id { get; set; }

    public long? cus_data_account_id { get; set; }

    public long? cus_merged_customer1 { get; set; }

    public long? cus_merged_customer2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cus_merged_datetime { get; set; }

    public long? cus_hidden_data_account_id { get; set; }

    public long? cus_all_data_account_id { get; set; }

    public long? cus_ms_sequence_id { get; set; }

    public Guid? cus_ms_change_guid { get; set; }
}
