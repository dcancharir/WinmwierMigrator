using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("tickets_discarded")]
public partial class tickets_discarded
{
    public long td_id { get; set; }

    public long td_ticket_id { get; set; }

    public long td_soft_count_id { get; set; }

    public long td_collection_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime td_created { get; set; }
}
