using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("blacklist_rules_bind")]
public partial class blacklist_rules_bind
{
    [Key]
    public int brb_id { get; set; }

    public int brb_list_type { get; set; }

    public int brb_rule_id { get; set; }

    public int? brb_bind_id { get; set; }
}
