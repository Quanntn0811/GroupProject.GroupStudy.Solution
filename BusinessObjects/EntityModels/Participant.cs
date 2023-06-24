using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[Keyless]
[Table("Participant")]
public partial class Participant
{
    [Column("userId")]
    public int? UserId { get; set; }

    [Column("groupId")]
    public int? GroupId { get; set; }

    [ForeignKey("GroupId")]
    public virtual Group? Group { get; set; }

    [ForeignKey("UserId")]
    public virtual User? User { get; set; }
}
