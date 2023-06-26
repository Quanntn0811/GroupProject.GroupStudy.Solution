using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects.EntityModels;

[Table("User")]
public partial class User
{
    [Key]
    [Column("userId")]
    public int UserId { get; set; }

    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("birthday", TypeName = "date")]
    public DateTime? Birthday { get; set; }

    [Column("address")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("roleId")]
    public int? RoleId { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role? Role { get; set; }
}
