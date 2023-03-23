﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Models.ResponseModels.Stats
{
    public class UsersStatsResponseModel
    {
        public int RegisteredCount { get; set; }
        public int BlockedCount { get; set; }
        public int QuizzesPassedCount { get; set; }
    }
}
