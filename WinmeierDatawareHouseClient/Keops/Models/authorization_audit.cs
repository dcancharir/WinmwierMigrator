using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("authorization_audit")]
public partial class authorization_audit
{
    [Key]
    public long aa_id { get; set; }

    public int aa_user_id { get; set; }

    public int aa_profile_id { get; set; }

    public int aa_authorizer_user_id { get; set; }

    public int aa_authorizer_profile_id { get; set; }

    [Column(TypeName = "money")]
    public decimal aa_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal aa_limit_min_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal aa_limit_max_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime aa_date { get; set; }

    public short aa_type { get; set; }

    public long aa_type_identifier { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? aa_authorizer_user_name { get; set; }
}
