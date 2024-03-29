﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        public bool IsDeleted { get; set; }
    }
}
