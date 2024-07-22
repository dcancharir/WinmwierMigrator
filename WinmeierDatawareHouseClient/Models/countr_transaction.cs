using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("countr_transaction")]
public partial class countr_transaction
{
    [Key]
    public long crt_transaction_id { get; set; }

    public long? crt_paid_ticket_id { get; set; }

    public long? crt_operation_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? crt_paid_amount { get; set; }

    public long? crt_new_ticket_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? crt_new_ticket_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? crt_cash_amount { get; set; }

    public int? crt_countr_id { get; set; }

    public long? crt_cashier_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime crt_gaming_day { get; set; }

    public int crt_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime crt_last_modified { get; set; }
}
