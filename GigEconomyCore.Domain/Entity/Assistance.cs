﻿using GigEconomyCore.Domain.Enum;

namespace GigEconomyCore.Domain.Entity
{
    public class Assistance
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        public AssistanceType Type { get; set;}
        public string SinisterCircumstances { get; set; }
        public AssistanceStatus Status { get; set; }
        public AssistanceRecords Records { get; set; }
        public Sinister Sinister { get; set; }
    }
}
