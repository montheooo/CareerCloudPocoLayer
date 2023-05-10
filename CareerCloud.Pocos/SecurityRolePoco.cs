﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Roles")]
    public class SecurityRolePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; } // Id (Primary key)

        [Column("Role")]
        public string Role { get; set; } // Role (length: 50)

        [Column("Is_Inactive")]
        public bool IsInactive { get; set; } // Is_Inactive

        public virtual ICollection<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }

    }
}
