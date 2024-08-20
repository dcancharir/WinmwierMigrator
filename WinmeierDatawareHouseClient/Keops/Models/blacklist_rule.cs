using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class blacklist_rule
{
    [Key]
    public int br_id { get; set; }

    public int br_description_id { get; set; }

    public int br_validation_id { get; set; }
}
