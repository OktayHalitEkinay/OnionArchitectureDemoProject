﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class BaseEntitiy
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}