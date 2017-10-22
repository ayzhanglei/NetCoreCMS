﻿/*************************************************************
 *          Project: NetCoreCMS                              *
 *              Web: http://dotnetcorecms.org                *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using NetCoreCMS.Framework.Core.Mvc.Models;
using System.Collections.Generic;

namespace NetCoreCMS.Modules.News.Models
{
    public class NeCategory : BaseModel<long>
    {
        public NeCategory()
        {  
            NewsList = new List<NeNewsCategory>();
        } 

        public List<NeNewsCategory> NewsList { get; set; }
    }
}