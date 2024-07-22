using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class sequence
{
    [Key]
    public int seq_id { get; set; }

    public long seq_next_value { get; set; }
}
