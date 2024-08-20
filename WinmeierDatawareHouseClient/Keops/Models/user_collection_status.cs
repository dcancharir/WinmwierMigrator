using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("user_collection_status")]
public partial class user_collection_status
{
    public long ucs_id { get; set; }

    public int ucs_venue_id { get; set; }

    public int ucs_user_id { get; set; }

    public int ucs_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ucs_init_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ucs_end_date { get; set; }

    public int? ucs_num_terminals { get; set; }
}
