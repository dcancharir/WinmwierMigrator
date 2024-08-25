using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("gpf_profile_id", "gpf_gui_id", "gpf_form_id")]
[Index("gpf_gui_id", "gpf_form_id", Name = "IX_gui_profile_forms_gpf_gui_id_gpf_form_id")]
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
}
