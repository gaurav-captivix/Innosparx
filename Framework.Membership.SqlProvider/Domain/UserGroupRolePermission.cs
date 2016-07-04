﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    using Framework.Domain.Mapping;
    using Framework.Membership;
    public class UserGroupRolePermission : BaseEntity, IUserGroupRolePermission
    {
        public Guid UserGroupID { get; set; }

        public Guid RoleID { get; set; }

        public virtual Role Role { get; set; }


        public string Permissions { get; set; }

        public virtual UserGroup Group { get; set; }

        IRole IUserGroupRolePermission.Role
        {
            get
            {
                return this.Role;
            }
        }

        IUserGroup IUserGroupRolePermission.Group
        {
            get
            {
                return this.Group;
            }
        }
    }
}