﻿using IceCoffee.DbCore.OptionalAttributes;
using IceCoffee.DbCore.Primitives.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSTY.Sdtd.WebApi.Data.Entities
{

    /// <summary>
    ///  T_StandardAccount    
    /// </summary>
    public class T_StandardAccount : EntityBase
    {
        /// <summary>
        /// 用户Id   
        /// </summary>
        [PrimaryKey]
        public string Fk_UserId { get; set; }

        /// <summary>
        /// 创建日期  
        /// </summary>
        [IgnoreUpdate, IgnoreInsert]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 账户名   
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 密码哈希值   
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// 密码盐值
        /// </summary>
        public string PasswordSalt { get; set; }

    }
}