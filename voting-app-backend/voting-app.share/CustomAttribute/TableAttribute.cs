﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_app.share.CustomAttribute
{
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }

        public TableAttribute(string name) : base()
        {
            Name = name;
        }
    }
}
