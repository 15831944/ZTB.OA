﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZTB.OA.Portal.Models
{
    public class MyExceptionFilterAttrbut:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            //自己处理异常信息
            Common.LogHelper.WriteLog(filterContext.Exception.ToString());
        }
    }
}