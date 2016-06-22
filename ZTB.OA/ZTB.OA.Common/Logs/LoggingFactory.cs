﻿// ==========================================
// Author                  :    WIN-JH13BJM99UM 
// Create Time           :    2016/6/22 10:51:01
// Update Time          :    2016/6/22 10:51:01
// ==========================================
// Class Description     :    
// ==========================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;

namespace ZTB.OA.Common.Logs
{
    public static class LoggingFactory
    { 
        public static ILogWrite GetDefaultLogger()
        {
            return new Log4NetWrite();
        }
    }
}