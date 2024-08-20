using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("sc_settlement_id", "sc_collection_id")]
[Index("sc_collection_id", Name = "IX_settlements_collections_sc_collection_id")]
[Index("sc_venue_id", Name = "IX_settlements_collections_sc_venue_id")]
public partial class settlements_collection
{
    [Key]
    public long sc_settlement_id { get; set; }

    [Key]
    public long sc_collection_id { get; set; }

    public int sc_venue_id { get; set; }
}
