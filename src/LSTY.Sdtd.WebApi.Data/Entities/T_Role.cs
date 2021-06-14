﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LSTY.Sdtd.WebApi.Data.Entities
{

    /// <summary>
    ///  T_Role    
    /// </summary>
    public class T_Role
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 创建日期 
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 说明   
        /// </summary>
        public string Description { get; set; }

    }
}
