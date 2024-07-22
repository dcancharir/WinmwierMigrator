using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("tg_terminal_id", "tg_element_id", "tg_element_type")]
public partial class terminal_group
{
    [Key]
    public int tg_terminal_id { get; set; }

    [Key]
    public long tg_element_id { get; set; }

    [Key]
    public int tg_element_type { get; set; }
}
