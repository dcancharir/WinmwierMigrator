using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("MajorVersionNumber", "MinorVersionNumber", "ReleaseDate")]
public partial class SqlServerVersion
{
    [Key]
    public byte MajorVersionNumber { get; set; }

    [Key]
    public short MinorVersionNumber { get; set; }

    [Key]
    public DateOnly ReleaseDate { get; set; }

    [StringLength(34)]
    [Unicode(false)]
    public string Branch { get; set; } = null!;

    [StringLength(99)]
    [Unicode(false)]
    public string Url { get; set; } = null!;

    public DateOnly MainstreamSupportEndDate { get; set; }

    public DateOnly ExtendedSupportEndDate { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string MajorVersionName { get; set; } = null!;

    [StringLength(67)]
    [Unicode(false)]
    public string MinorVersionName { get; set; } = null!;
}
