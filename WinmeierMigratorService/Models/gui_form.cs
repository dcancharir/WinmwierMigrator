using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("gf_gui_id", "gf_form_id")]
public partial class gui_form
{
    [Key]
    public int gf_gui_id { get; set; }

    [Key]
    public int gf_form_id { get; set; }

    public int gf_form_order { get; set; }

    public int gf_nls_id { get; set; }

    [InverseProperty("gui_form")]
    public virtual ICollection<gui_profile_form> gui_profile_forms { get; set; } = new List<gui_profile_form>();
}
