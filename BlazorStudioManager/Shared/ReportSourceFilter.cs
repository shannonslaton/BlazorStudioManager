﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudioManager.Shared
{
    public class ReportSourceFilter
    {
        public dynamic Value { get; set; }
        public string Member { get; set; }
        public string OperatorString { get; set; }
    }
}
