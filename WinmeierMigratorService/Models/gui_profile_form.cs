using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("gpf_profile_id", "gpf_gui_id", "gpf_form_id")]
public partial class gui_profile_form
{
    [Key]
    public int gpf_profile_id { get; set; }

    [Key]
    public int gpf_gui_id { get; set; }

    [Key]
    public int gpf_form_id { get; set; }

    public bool gpf_read_perm { get; set; }

    public bool gpf_write_perm { get; set; }

    public bool gpf_delete_perm { get; set; }

    public bool gpf_execute_perm { get; set; }

    [ForeignKey("gpf_profile_id")]
    [InverseProperty("gui_profile_forms")]
    public virtual gui_user_profile gpf_profile { get; set; } = null!;

    [ForeignKey("gpf_gui_id, gpf_form_id")]
    [InverseProperty("gui_profile_forms")]
    public virtual gui_form gui_form { get; set; } = null!;
}
