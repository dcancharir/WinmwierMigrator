using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("Card_Generation")]
public partial class Card_Generation
{
    [Key]
    public int cg_site_id { get; set; }

    public long cg_last_sequence { get; set; }
}
