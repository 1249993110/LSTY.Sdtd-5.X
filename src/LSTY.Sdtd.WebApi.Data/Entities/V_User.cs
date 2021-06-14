﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LSTY.Sdtd.WebApi.Data.Entities
{
    /// <summary>
    ///  V_User    
    /// </summary>
    public class V_User
    {
        /// <summary>
        /// 无    
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public string LastLoginIpAddress { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public Guid? RoleId { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public int? MaxInstanceCount { get; set; }

        /// <summary>
        /// 无    
        /// </summary>
        public string SecretId { get; set; }

    }

}
