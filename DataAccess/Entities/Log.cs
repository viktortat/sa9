﻿using Core.Entities;
using System;

namespace DataAccess.Entities
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public string LogDetail { get; set; }
        public DateTime Date { get; set; }
        public string Audit { get; set; }
    }
}
