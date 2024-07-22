using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("at_machine_id", Name = "IX_alesis_terminals", IsUnique = true)]
public partial class alesis_terminal
{
    [Key]
    public int at_terminal_id { get; set; }

    public int at_machine_id { get; set; }

    public long? at_session_id { get; set; }

    public int at_status { get; set; }
}
