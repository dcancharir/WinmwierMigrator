using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("promogame_type_play_session")]
[Index("ptp_gametype", Name = "IDX_Game_Type")]
[Index("ptp_playsession_id", Name = "IDX_Play_Session_Id")]
public partial class promogame_type_play_session
{
    [Key]
    public long ptp_playsession_id { get; set; }

    public long ptp_gametype { get; set; }
}
