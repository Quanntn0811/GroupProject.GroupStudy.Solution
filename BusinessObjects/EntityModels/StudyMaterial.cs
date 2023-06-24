using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[Table("StudyMaterial")]
public partial class StudyMaterial
{
    [Key]
    [Column("studyMaterialID")]
    public int StudyMaterialId { get; set; }

    [Column("slotId")]
    public int? SlotId { get; set; }

    [Column("title")]
    public int? Title { get; set; }

    [Column("content")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Content { get; set; }

    [Column("link")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Link { get; set; }

    [Column("status")]
    public bool? Status { get; set; }

    [ForeignKey("SlotId")]
    [InverseProperty("StudyMaterials")]
    public virtual Slot? Slot { get; set; }
}
