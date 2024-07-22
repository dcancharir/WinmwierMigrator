using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class gui_user_profile
{
    [Key]
    public int gup_profile_id { get; set; }

    [StringLength(40)]
    public string gup_name { get; set; } = null!;

    public byte[]? gup_timestamp { get; set; }

    public int gup_max_users { get; set; }

    public int? gup_master_id { get; set; }

    public long? gup_master_sequence_id { get; set; }

    [InverseProperty("gpf_profile")]
    public virtual ICollection<gui_profile_form> gui_profile_forms { get; set; } = new List<gui_profile_form>();

    [InverseProperty("gu_profile")]
    public virtual ICollection<gui_user> gui_users { get; set; } = new List<gui_user>();
}
