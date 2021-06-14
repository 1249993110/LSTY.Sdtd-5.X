﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LSTY.Sdtd.WebApi.Data.Entities
{
    /// <summary>
    ///  T_Permission    
    /// </summary>
    public class T_Permission
    {
        /// <summary>
        /// 无    
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 创建日期   
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 路由开始部分 
        /// </summary>
        public string PathStartsSegments { get; set; }

        /// <summary>
        /// 是否启用  
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 说明  
        /// </summary>
        public string Description { get; set; }

    }

}
