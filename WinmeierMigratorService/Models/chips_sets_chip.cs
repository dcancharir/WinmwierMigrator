using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("csc_chip_id", "csc_set_id")]
public partial class chips_sets_chip
{
    [Key]
    public int csc_chip_id { get; set; }

    [Key]
    public int csc_set_id { get; set; }
}
