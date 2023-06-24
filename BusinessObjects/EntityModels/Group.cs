﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[Table("Group")]
public partial class Group
{
    [Key]
    [Column("groupId")]
    public int GroupId { get; set; }

    [Column("subjectId")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SubjectId { get; set; }

    [Column("size")]
    public int? Size { get; set; }

    [Column("status")]
    public bool? Status { get; set; }

    [InverseProperty("Group")]
    public virtual ICollection<Slot> Slots { get; set; } = new List<Slot>();

    [ForeignKey("SubjectId")]
    [InverseProperty("Groups")]
    public virtual Subject? Subject { get; set; }
}
