using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class wkt_player_info_field
{
    [Key]
    public int pif_field_id { get; set; }

    [StringLength(50)]
    public string pif_name { get; set; } = null!;

    public bool pif_shown { get; set; }

    public bool pif_user_allow_edit { get; set; }

    public int pif_type { get; set; }

    public int pif_min_length { get; set; }

    public int pif_max_length { get; set; }

    public bool pif_editable { get; set; }

    public int pif_order { get; set; }
}
