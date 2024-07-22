using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("cut_customer_id", "cut_gaming_day", "cut_visit_id", Name = "IX_cut_customer_id__cut_gaming_day__cut_visit_id")]
[Index("cut_gaming_day", Name = "IX_cut_gaming_day")]
[Index("cut_gaming_day", "cut_visit_id", Name = "IX_cut_gaming_day_cut_visit_id")]
[Index("cut_visit_id", "cut_gaming_day", Name = "IX_cut_visit_id_cut_gaming_day")]
public partial class customer_visit
{
    [Key]
    public long cut_visit_id { get; set; }

    public int cut_gaming_day { get; set; }

    public long cut_customer_id { get; set; }

    public int cut_level { get; set; }

    public bool cut_is_vip { get; set; }

    public byte? cut_age { get; set; }

    public byte? cut_gender { get; set; }
}
