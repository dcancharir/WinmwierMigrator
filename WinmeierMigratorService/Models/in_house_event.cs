using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class in_house_event
{
    [Key]
    public long ihe_event_id { get; set; }

    public int ihe_site_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ihe_event_inserted_in_local_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ihe_event_inserted_in_utc_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ihe_event_datetime_in_local_time { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ihe_event_datetime_in_utc_time { get; set; }

    public int ihe_event_type { get; set; }

    public long ihe_customer_id { get; set; }

    public int? ihe_egm_id { get; set; }
}
