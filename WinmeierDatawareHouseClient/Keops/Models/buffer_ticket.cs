using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("bt_ticket_id", "bt_timestamp")]
public partial class buffer_ticket
{
    [Key]
    public long bt_ticket_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime bt_timestamp { get; set; }
}
