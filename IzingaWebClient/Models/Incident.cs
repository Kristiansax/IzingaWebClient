﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzingaWebClient.Models
{
    public class Incident
    {
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ResetTime { get; set; }

        public Incident(string description, DateTime startTime, DateTime resetTime)
        {
            Description = description;
            StartTime = startTime;
            ResetTime = resetTime;
        }
    }
}
