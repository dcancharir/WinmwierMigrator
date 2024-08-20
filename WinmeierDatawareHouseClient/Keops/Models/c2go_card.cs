using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class c2go_card
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string c2g_card_trackdata { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? c2g_insert_datetime { get; set; }
}
