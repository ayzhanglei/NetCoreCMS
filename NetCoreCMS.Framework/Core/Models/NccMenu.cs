﻿/*
 * Author: Xonaki
 * Website: http://xonaki.com
 * Copyright (c) xonaki.com
 * License: BSD (3 Clause)
*/
using NetCoreCMS.Framework.Core.Mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreCMS.Framework.Core.Models
{
    public class NccMenu : IBaseModel<long>
    {
        public NccMenu()
        {
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
            CreateBy = ModifyBy = BaseModel.GetCurrentUserId();
            Status = EntityStatus.New;
            VersionNumber = 1;
        }

        [Key]
        public long Id { get; set; }
        public int VersionNumber { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public long CreateBy { get; set; }
        public long ModifyBy { get; set; }
        public int Status { get; set; }
        public MenuPosition Position { get; set; }
        public string MenuIconCls { get; set; }
        public List<NccMenuItem> MenuItems { get; set; }
        public NccMenuFor MenuFor { get; set; }
        public int MenuOrder { get; set; }

        public enum MenuPosition
        {
            Top,
            Main,
            Left,
            Right,
            Footer
        }
        public enum NccMenuFor
        {
            Site,
            Admin
        }
    }   
}
