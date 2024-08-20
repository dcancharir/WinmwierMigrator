using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class ocl_linkedexternalaccount
{
    public int Id { get; set; }

    public long WigosAccountId { get; set; }

    [StringLength(100)]
    public string ProviderAccountId { get; set; } = null!;

    public bool Processed { get; set; }

    public int ProviderTypeId { get; set; }

    public long ms_SequenceId { get; set; }
}
