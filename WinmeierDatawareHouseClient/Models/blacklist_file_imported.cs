using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Keyless]
[Table("blacklist_file_imported")]
[Index("blkf_metaphone_key_lastname_1", Name = "IX_blacklist_file_imported_mklastname1")]
[Index("blkf_metaphone_key_lastname_2", Name = "IX_blacklist_file_imported_mklastname2")]
[Index("blkf_metaphone_key_middle_name", Name = "IX_blacklist_file_imported_mkmiddelname")]
[Index("blkf_metaphone_key_name", Name = "IX_blacklist_file_imported_mkname")]
public partial class blacklist_file_imported
{
    public int blkf_id { get; set; }

    [StringLength(50)]
    public string blkf_name { get; set; } = null!;

    [StringLength(50)]
    public string? blkf_middle_name { get; set; }

    [StringLength(50)]
    public string blkf_lastname_1 { get; set; } = null!;

    [StringLength(50)]
    public string? blkf_lastname_2 { get; set; }

    public short blkf_document_type { get; set; }

    [StringLength(20)]
    public string blkf_document { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime bklf_exclusion_date { get; set; }

    public short? bklf_reason_type { get; set; }

    public string bklf_reason_description { get; set; } = null!;

    public int? bklf_exclusion_duration { get; set; }

    public short? bklf_origin { get; set; }

    [StringLength(50)]
    public string? blkf_reference { get; set; }

    public int blkf_id_type { get; set; }

    [StringLength(50)]
    public string? blkf_metaphone_key_name { get; set; }

    [StringLength(50)]
    public string? blkf_metaphone_key_middle_name { get; set; }

    [StringLength(50)]
    public string? blkf_metaphone_key_lastname_1 { get; set; }

    [StringLength(50)]
    public string? blkf_metaphone_key_lastname_2 { get; set; }
}
