﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Membership
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Interface for role.
    /// </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IRole
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        ///
        /// <value>
        ///     The identifier.
        /// </value>
        ///-------------------------------------------------------------------------------------------------
        Guid ID { get; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        ///
        /// <value>
        ///     The name.
        /// </value>
        ///-------------------------------------------------------------------------------------------------
        string Name { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        ///
        /// <value>
        ///     The description.
        /// </value>
        ///-------------------------------------------------------------------------------------------------
        string Description { get; set; }

        ICollection<IUserGroupRolePermission> Permissions { get; }
    }
}
