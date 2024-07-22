using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("blacklist_internal_block_list")]
public partial class blacklist_internal_block_list
{
    [Key]
    public long bkl_id { get; set; }

    public long bkl_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bkl_inclusion_date { get; set; }

    public short bkl_reason { get; set; }

    [Unicode(false)]
    public string? bkl_reason_description { get; set; }
}
