using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class drop_movement
{
    public long dm_id { get; set; }

    public int dm_type { get; set; }

    public int dm_gui_user { get; set; }

    [Column(TypeName = "money")]
    public decimal dm_value { get; set; }

    public int dm_value_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dm_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dm_datetime_last_modified { get; set; }

    public long? dm_previous_id { get; set; }

    public long? dm_cage_movement_id { get; set; }

    public long dm_gaming_table_session_id { get; set; }

    public bool? dm_is_buyin { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? dm_player_name { get; set; }

    public int? dm_seat_position { get; set; }
}
